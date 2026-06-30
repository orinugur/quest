using System;
using System.Windows.Forms;

namespace QuestProject.Forms
{
    public partial class FormSetup : Form
    {
        public FormSetup()
        {
            //SetPageTitle("SETUP");
            InitializeComponent();
        }

        private void FormSetup_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object? sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveAxis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("환경 설정이 저장되었습니다.", "저장 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("환경 설정이 로드되었습니다.", "로드 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
