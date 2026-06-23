using System;
using System.Windows.Forms;

namespace QuestProject.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        // 기존 Form 기반 필드 및 메서드 주석 처리
        // private Form? activeForm = null;
        // private void ShowChildForm(Form childForm)
        // {
        //     if (activeForm != null)
        //     {
        //         activeForm.Close();
        //         pnlContent.Controls.Remove(activeForm);
        //         activeForm.Dispose();
        //     }
        //     activeForm = childForm;
        //     childForm.TopLevel = false;
        //     childForm.FormBorderStyle = FormBorderStyle.None;
        //     childForm.Dock = DockStyle.Fill;
        //     pnlContent.Controls.Add(childForm);
        //     childForm.BringToFront();
        //     childForm.Show();
        // }

        private Control? activeControl = null;

        private void ShowChildForm(Control childControl)
        {
            // 1. 이미 열려있는 컨트롤이 있다면 제거하고 해제합니다.
            if (activeControl != null)
            {
                pnlContent.Controls.Remove(activeControl);
                activeControl.Dispose();
            }

            // 2. 새로운 컨트롤 설정
            activeControl = childControl;

            // 3. 자식 컨트롤 설정
            childControl.Dock = DockStyle.Fill;

            // 4. pnlContent에 추가
            pnlContent.Controls.Add(childControl);
            childControl.BringToFront();

            // 5. 컨트롤 띄우기
            childControl.Show();
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
    }
}
