using System;
using System.Windows.Forms;
using QuestProject.Common;

namespace QuestProject.Forms
{
    public partial class FormManual : Form
    {
        public FormManual()
        {
            InitializeComponent();

            // 이벤트 핸들러 연결
            rbAxisX.CheckedChanged += RbAxis_CheckedChanged;
            rbAxisY.CheckedChanged += RbAxis_CheckedChanged;
            rbAxisZ.CheckedChanged += RbAxis_CheckedChanged;
            rbAxisT.CheckedChanged += RbAxis_CheckedChanged;

            btnAsyncMove.Click += BtnAsyncMove_Click;
            btnSyncMove.Click += BtnSyncMove_Click;
            timerUpdate.Tick += TimerUpdate_Tick;

            this.Load += FormManual_Load;
        }

        private void FormManual_Load(object? sender, EventArgs e)
        {
            UpdateSelectedAxisInfo();
            timerUpdate.Start();
        }

        private void RbAxis_CheckedChanged(object? sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                UpdateSelectedAxisInfo();
            }
        }

        private void TimerUpdate_Tick(object? sender, EventArgs e)
        {
            var axis = GetSelectedAxis();
            if (axis != null)
            {
                txtCurrentPosition.Text = axis.CurrentPosition.ToString("F2");
            }
        }

        private AxisData GetSelectedAxis()
        {
            if (rbAxisX.Checked) return GlobalData.AxisX;
            if (rbAxisY.Checked) return GlobalData.AxisY;
            if (rbAxisZ.Checked) return GlobalData.AxisZ;
            if (rbAxisT.Checked) return GlobalData.AxisT;
            return GlobalData.AxisX;
        }

        private void UpdateSelectedAxisInfo()
        {
            var axis = GetSelectedAxis();
            if (axis != null)
            {
                txtCurrentPosition.Text = axis.CurrentPosition.ToString("F2");
                
                // NumericUpDown 범위 내에서 속도 값 설정
                decimal speedVal = (decimal)axis.Speed;
                if (speedVal < numSpeed.Minimum) speedVal = numSpeed.Minimum;
                if (speedVal > numSpeed.Maximum) speedVal = numSpeed.Maximum;
                numSpeed.Value = speedVal;
            }
        }

        private void BtnAsyncMove_Click(object? sender, EventArgs e)
        {
            MoveAxis(isSync: false);
        }

        private void btnSyncMove_Click(object sender, EventArgs e)
        {
            // Designer에 btnSyncMove click이 바인딩되거나 btnSyncMove_Click(object? sender, EventArgs e) 와 이름 일치시키기 위함
        }

        private void BtnSyncMove_Click(object? sender, EventArgs e)
        {
            MoveAxis(isSync: true);
        }

        private void MoveAxis(bool isSync)
        {
            var axis = GetSelectedAxis();
            if (axis == null) return;

            double currentPos = axis.CurrentPosition;
            double speed = (double)numSpeed.Value;
            double targetInput = (double)numTargetPosition.Value;

            // 속도 설정 반영
            axis.Speed = speed;

            // 최종 위치값 계산
            double finalPos = currentPos;
            string moveModeStr = "";
            if (rbAbsolute.Checked)
            {
                finalPos = targetInput;
                moveModeStr = "절대위치";
            }
            else if (rbRelative.Checked)
            {
                finalPos = currentPos + targetInput;
                moveModeStr = "상대위치";
            }

            // 소프트웨어 리밋(LimitMin, LimitMax) 검증
            if (finalPos < axis.LimitMin || finalPos > axis.LimitMax)
            {
                string limitWarn = $"이동 목표 위치({finalPos:F2})가 소프트웨어 리밋 한계({axis.LimitMin:F2} ~ {axis.LimitMax:F2})를 벗어났습니다.";
                LogHelper.WriteLog("Manual", $"[Limit Warning] {axis.Name} target position {finalPos:F2} exceeds software limits [{axis.LimitMin:F2} ~ {axis.LimitMax:F2}]");
                MessageBox.Show(limitWarn, "리밋 경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string syncModeStr = isSync ? "동기" : "비동기";

            // 로그 기록 (선택된축, 현재위치값, 속도, 목표위치값 -> 최종위치값)
            string logMsg = $"[Manual Move] 축선택: {axis.Name}, 현재위치값: {currentPos:F2}, 속도: {speed:F2}, 목표위치값: {targetInput:F2} -> 최종위치값: {finalPos:F2} ({moveModeStr}, {syncModeStr})";
            LogHelper.WriteLog("Manual", logMsg);

            if (isSync)
            {
                try
                {
                    // UI 조작 방지를 위해 컨트롤 비활성화
                    SetControlsEnabled(false);

                    // 축 이동
                    AxisController.MoveTo(axis, finalPos);

                    // 동기식 대기 루프
                    while (Math.Abs(axis.CurrentPosition - finalPos) > 0.001)
                    {
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(20);
                    }
                }
                finally
                {
                    // 컨트롤 활성화 복구
                    SetControlsEnabled(true);
                }
            }
            else
            {
                // 비동기식 이동 개시
                AxisController.MoveTo(axis, finalPos);
            }
        }

        private void SetControlsEnabled(bool enabled)
        {
            gbAxisSelection.Enabled = enabled;
            gbMotionParams.Enabled = enabled;
            gbMoveMode.Enabled = enabled;
            gbActions.Enabled = enabled;
        }
    }
}
