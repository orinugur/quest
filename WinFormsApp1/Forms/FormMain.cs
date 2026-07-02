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
        }

        private Form? activeForm = null;

        private void ShowChildForm(Form childForm)
        {
            // 1. 이미 열려있는 폼이 있다면 닫고 제거 후 해제합니다.
            if (activeForm != null)
            {
                activeForm.Close();
                pnlContent.Controls.Remove(activeForm);
                activeForm.Dispose();
            }

            // 2. 새로운 폼 설정 및 속성 변경
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // 3. pnlContent에 추가하고 띄우기
            pnlContent.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            ShowChildForm(new FormAuto());
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            ShowChildForm(new FormManual());
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            ShowChildForm(new FormLog());
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            ShowChildForm(new FormSetup());

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
            // 1. Logger 초기화 (이벤트 구독 시작)
            LogHelper.Initialize();

            // 2. config.ini 에서 로그 삭제 주기 읽어오기 (기본값 3)
            int retentionMonths = 3;
            var iniData = IniHelper.Load("config.ini");
            if (iniData.TryGetValue("System", out var sysConfig) && 
                sysConfig.TryGetValue("LogRetentionMonths", out var val) && 
                int.TryParse(val, out int parsed))
            {
                retentionMonths = parsed;
            }

            // 3. 오래된 로그 삭제 실행
            LogHelper.DeleteOldLogs(retentionMonths);

            // 4. 시스템 시작 로그 기록 (이벤트 호출)
            LogHelper.WriteLog("system", "program start");
        }
    }
}
