using System;
using System.Windows.Forms;
using QuestProject.Common;

namespace QuestProject.Forms
{
    public partial class FormMain : Form
    {
            public FormMain()
            {
                InitializeComponent();
                this.Load += FormMain_Load;
                this.FormClosed += FormMain_FormClosed;
            }

        private FormAuto? _formAuto;
        private FormManual? _formManual;
        private FormLog? _formLog;
        private FormSetup? _formSetup;
        private Form? activeForm = null;

        private void ShowChildForm(Form childForm)
        {
            // 1. 이미 열려있는 폼이 있다면 화면에서 숨김 처리합니다.
            if (activeForm != null)
            {
                activeForm.Hide();
            }

            // 2. 새로운 폼이 패널에 등록되지 않은 경우 추가합니다.
            if (!pnlContent.Controls.Contains(childForm))
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                pnlContent.Controls.Add(childForm);
            }

            // 3. 폼 활성화 및 표시
            activeForm = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            if (_formAuto == null || _formAuto.IsDisposed) _formAuto = new FormAuto();
            ShowChildForm(_formAuto);
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            if (_formManual == null || _formManual.IsDisposed) _formManual = new FormManual();
            ShowChildForm(_formManual);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (_formLog == null || _formLog.IsDisposed) _formLog = new FormLog();
            ShowChildForm(_formLog);
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            if (_formSetup == null || _formSetup.IsDisposed) _formSetup = new FormSetup();
            ShowChildForm(_formSetup);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            // 초기화 
            LogHelper.Initialize();

            // config.ini 에서 로그 삭제 주기 읽어오기
            int retentionMonths = 3;
            var iniData = IniHelper.Load("config.ini");
            if (iniData.TryGetValue("System", out var sysConfig) && 
                sysConfig.TryGetValue("LogRetentionMonths", out var val) && 
                int.TryParse(val, out int parsed))
            {
                retentionMonths = parsed;
            }

            // 로그 삭제 주기 실행
            LogHelper.DeleteOldLogs(retentionMonths);

            // 프로그램 시작 로그
            LogHelper.WriteLog("system", "program start");

            // Axis 설정 로드 및 로딩 위치로 이동 개시
            AxisController.LoadConfiguration("config.ini");
            AxisController.MoveToLoadingPosition();

            // UI 실시간 모니터링 타이머 시작
            uiTimer.Start();
        }

        private void UiTimer_Tick(object? sender, EventArgs e)
        {
            bool allAtLoading = true;
            foreach (var axis in GlobalData.AllAxes)
            {
                if (Math.Abs(axis.CurrentPosition - axis.LoadingPosition) > 0.001)
                {
                    allAtLoading = false;
                    break;
                }
            }

            lblStatus.Text = allAtLoading ? "상태: All Axes at Loading Position" : "상태: Moving to Loading Position...";

            // Axis X
            txtXCurrent.Text = GlobalData.AxisX.CurrentPosition.ToString("F2");
            txtXLoading.Text = GlobalData.AxisX.LoadingPosition.ToString("F2");
            txtXSpeed.Text = GlobalData.AxisX.Speed.ToString("F1");

            // Axis Y
            txtYCurrent.Text = GlobalData.AxisY.CurrentPosition.ToString("F2");
            txtYLoading.Text = GlobalData.AxisY.LoadingPosition.ToString("F2");
            txtYSpeed.Text = GlobalData.AxisY.Speed.ToString("F1");

            // Axis Z
            txtZCurrent.Text = GlobalData.AxisZ.CurrentPosition.ToString("F2");
            txtZLoading.Text = GlobalData.AxisZ.LoadingPosition.ToString("F2");
            txtZSpeed.Text = GlobalData.AxisZ.Speed.ToString("F1");

            // Axis T
            txtTCurrent.Text = GlobalData.AxisT.CurrentPosition.ToString("F2");
            txtTLoading.Text = GlobalData.AxisT.LoadingPosition.ToString("F2");
            txtTSpeed.Text = GlobalData.AxisT.Speed.ToString("F1");
        }
        
        // Form 종료시 실행
        private void FormMain_FormClosed(object? sender, FormClosedEventArgs e)
        {
            try
            {
                LogHelper.WriteLog("System", "program Exit");
            }
            catch
            {
                
            }
        }
        
    }
}
