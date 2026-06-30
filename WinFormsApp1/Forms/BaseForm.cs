using System.Windows.Forms;

namespace QuestProject.Forms
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeBaseComponent();
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
