using System.Windows.Forms;

namespace QuestProject.Forms
{
    public partial class FormSetup : Form
    {
        private TabControl? tabControl1;
        private TabPage? tabPage1;
        private Button? button1;
        private TabPage? tabPage2;

        public FormSetup()
        {
            //SetPageTitle("SETUP");
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(15, 60);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(770, 450);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(762, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "축 설정";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(762, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "기타";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(119, 246);
            button1.Name = "button1";
            button1.Size = new Size(111, 52);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // 
            // FormSetup
            // 
            this.ClientSize = new Size(800, 530);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormSetup";
            this.Controls.SetChildIndex(this.tabControl1, 0);
            //if (this.lblTitle != null)
            //{
            //    this.Controls.SetChildIndex(this.lblTitle, 0);
            //}
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void FormSetup_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object? sender, EventArgs e)
        {

        }
    }
}
