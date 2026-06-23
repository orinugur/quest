using System.Drawing;
using System.Windows.Forms;

namespace QuestProject.Forms
{
    // 기존 Form 상속 구조 주석 처리 후 UserControl 상속으로 변경
    // public class BaseForm : Form
    public class BaseForm : UserControl
    {
        protected Label? lblTitle;

        public BaseForm()
        {
            InitializeBaseComponent();
        }

        private void InitializeBaseComponent()
        {
            this.lblTitle = new Label();
            this.SuspendLayout();

            // lblTitle 설정 (좌상단 타이틀)
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTitle.Location = new Point(15, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(150, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Page Title";
            this.lblTitle.ForeColor = Color.Black;

            // BaseForm 기본 설정
            // 기존 ClientSize 및 FormBorderStyle 설정 주석 처리 후 UserControl 설정 추가
            // this.ClientSize = new Size(800, 530);
            // this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(800, 530);
            this.Controls.Add(this.lblTitle);
            this.Name = "BaseForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // 타이틀을 변경할 수 있는 메서드
        public void SetPageTitle(string? title)
        {
            if (lblTitle != null)
            {
                lblTitle.Text = title;
            }
        }
    }
}
