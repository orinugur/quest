namespace QuestProject.Forms
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private float _axisX;
        private float _axisY;
        private float _axisZ;
        private float _axisT;
        public float AxisX
        {
            get { return _axisX; }
            set { _axisX = value; }
        }
        public float AxisY
        {
            get { return _axisY; }
            set { _axisY = value; }
        }
        public float AxisZ
        {
            get { return _axisZ; }
            set { _axisZ = value; }
        }
        public float AxisT
        {
            get { return _axisT; }
            set { _axisT = value; }
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlBottom = new Panel();
            btnManual = new Button();
            btnLog = new Button();
            btnSetup = new Button();
            btnExit = new Button();
            btnAuto = new Button();
            pnlContent = new Panel();
            label1 = new Label();
            pnlBottom.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(btnManual);
            pnlBottom.Controls.Add(btnLog);
            pnlBottom.Controls.Add(btnSetup);
            pnlBottom.Controls.Add(btnExit);
            pnlBottom.Controls.Add(btnAuto);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 492);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(784, 70);
            pnlBottom.TabIndex = 0;
            // 
            // btnManual
            // 
            btnManual.Location = new Point(167, 9);
            btnManual.Name = "btnManual";
            btnManual.Size = new Size(149, 52);
            btnManual.TabIndex = 4;
            btnManual.Text = "Manual";
            btnManual.UseVisualStyleBackColor = true;
            btnManual.Click += btnManual_Click;
            // 
            // btnLog
            // 
            btnLog.Location = new Point(322, 9);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(149, 52);
            btnLog.TabIndex = 3;
            btnLog.Text = "Log";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // btnSetup
            // 
            btnSetup.Location = new Point(477, 9);
            btnSetup.Name = "btnSetup";
            btnSetup.Size = new Size(149, 52);
            btnSetup.TabIndex = 2;
            btnSetup.Text = "Setup";
            btnSetup.UseVisualStyleBackColor = true;
            btnSetup.Click += btnSetup_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(632, 9);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(149, 52);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnAuto
            // 
            btnAuto.Location = new Point(12, 9);
            btnAuto.Name = "btnAuto";
            btnAuto.Size = new Size(149, 52);
            btnAuto.TabIndex = 0;
            btnAuto.Text = "Auto";
            btnAuto.UseVisualStyleBackColor = true;
            btnAuto.Click += btnAuto_Click;
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(label1);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(784, 492);
            pnlContent.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(273, 164);
            label1.Name = "label1";
            label1.Size = new Size(209, 45);
            label1.TabIndex = 5;
            label1.Text = "Main Display";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 562);
            Controls.Add(pnlContent);
            Controls.Add(pnlBottom);
            Name = "Main";
            Text = "Form1";
            pnlBottom.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBottom;
        private Panel pnlContent;
        private Button btnAuto;
        private Button btnManual;
        private Button btnLog;
        private Button btnSetup;
        private Button btnExit;
        private Label label1;
    }
}
