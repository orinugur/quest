#nullable enable

using System.Drawing;
using System.Windows.Forms;

namespace QuestProject.Forms
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlBottom = new Panel();
            btnManual = new Button();
            btnLog = new Button();
            btnSetup = new Button();
            btnExit = new Button();
            btnAuto = new Button();
            pnlContent = new Panel();
            lblTitle = new Label();
            lblStatus = new Label();
            gbAxisX = new GroupBox();
            txtXSpeed = new TextBox();
            txtXLoading = new TextBox();
            txtXCurrent = new TextBox();
            lblXSpeed = new Label();
            lblXLoading = new Label();
            lblXCurrent = new Label();
            gbAxisY = new GroupBox();
            txtYSpeed = new TextBox();
            txtYLoading = new TextBox();
            txtYCurrent = new TextBox();
            lblYSpeed = new Label();
            lblYLoading = new Label();
            lblYCurrent = new Label();
            gbAxisZ = new GroupBox();
            txtZSpeed = new TextBox();
            txtZLoading = new TextBox();
            txtZCurrent = new TextBox();
            lblZSpeed = new Label();
            lblZLoading = new Label();
            lblZCurrent = new Label();
            gbAxisT = new GroupBox();
            txtTSpeed = new TextBox();
            txtTLoading = new TextBox();
            txtTCurrent = new TextBox();
            lblTSpeed = new Label();
            lblTLoading = new Label();
            lblTCurrent = new Label();
            uiTimer = new System.Windows.Forms.Timer(components);
            pnlBottom.SuspendLayout();
            pnlContent.SuspendLayout();
            gbAxisX.SuspendLayout();
            gbAxisY.SuspendLayout();
            gbAxisZ.SuspendLayout();
            gbAxisT.SuspendLayout();
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
            pnlContent.Controls.Add(lblTitle);
            pnlContent.Controls.Add(lblStatus);
            pnlContent.Controls.Add(gbAxisX);
            pnlContent.Controls.Add(gbAxisY);
            pnlContent.Controls.Add(gbAxisZ);
            pnlContent.Controls.Add(gbAxisT);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(784, 492);
            pnlContent.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("맑은 고딕", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(65, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Main";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("맑은 고딕", 10F);
            lblStatus.Location = new Point(20, 55);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(219, 19);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "상태: All Axes at Loading Position";
            // 
            // gbAxisX
            // 
            gbAxisX.Controls.Add(txtXSpeed);
            gbAxisX.Controls.Add(txtXLoading);
            gbAxisX.Controls.Add(txtXCurrent);
            gbAxisX.Controls.Add(lblXSpeed);
            gbAxisX.Controls.Add(lblXLoading);
            gbAxisX.Controls.Add(lblXCurrent);
            gbAxisX.Location = new Point(20, 90);
            gbAxisX.Name = "gbAxisX";
            gbAxisX.Size = new Size(350, 180);
            gbAxisX.TabIndex = 2;
            gbAxisX.TabStop = false;
            gbAxisX.Text = "Axis X";
            // 
            // txtXSpeed
            // 
            txtXSpeed.BackColor = SystemColors.Control;
            txtXSpeed.Location = new Point(160, 112);
            txtXSpeed.Name = "txtXSpeed";
            txtXSpeed.ReadOnly = true;
            txtXSpeed.Size = new Size(160, 23);
            txtXSpeed.TabIndex = 5;
            txtXSpeed.Text = "0.0";
            // 
            // txtXLoading
            // 
            txtXLoading.BackColor = SystemColors.Control;
            txtXLoading.Location = new Point(160, 72);
            txtXLoading.Name = "txtXLoading";
            txtXLoading.ReadOnly = true;
            txtXLoading.Size = new Size(160, 23);
            txtXLoading.TabIndex = 4;
            txtXLoading.Text = "0.00";
            // 
            // txtXCurrent
            // 
            txtXCurrent.BackColor = SystemColors.Control;
            txtXCurrent.Location = new Point(160, 32);
            txtXCurrent.Name = "txtXCurrent";
            txtXCurrent.ReadOnly = true;
            txtXCurrent.Size = new Size(160, 23);
            txtXCurrent.TabIndex = 3;
            txtXCurrent.Text = "0.00";
            // 
            // lblXSpeed
            // 
            lblXSpeed.AutoSize = true;
            lblXSpeed.Location = new Point(20, 115);
            lblXSpeed.Name = "lblXSpeed";
            lblXSpeed.Size = new Size(106, 15);
            lblXSpeed.TabIndex = 2;
            lblXSpeed.Text = "현재 속도 (mm/s):";
            // 
            // lblXLoading
            // 
            lblXLoading.AutoSize = true;
            lblXLoading.Location = new Point(20, 75);
            lblXLoading.Name = "lblXLoading";
            lblXLoading.Size = new Size(96, 15);
            lblXLoading.TabIndex = 1;
            lblXLoading.Text = "로딩 위치 (mm):";
            // 
            // lblXCurrent
            // 
            lblXCurrent.AutoSize = true;
            lblXCurrent.Location = new Point(20, 35);
            lblXCurrent.Name = "lblXCurrent";
            lblXCurrent.Size = new Size(96, 15);
            lblXCurrent.TabIndex = 0;
            lblXCurrent.Text = "현재 위치 (mm):";
            // 
            // gbAxisY
            // 
            gbAxisY.Controls.Add(txtYSpeed);
            gbAxisY.Controls.Add(txtYLoading);
            gbAxisY.Controls.Add(txtYCurrent);
            gbAxisY.Controls.Add(lblYSpeed);
            gbAxisY.Controls.Add(lblYLoading);
            gbAxisY.Controls.Add(lblYCurrent);
            gbAxisY.Location = new Point(410, 90);
            gbAxisY.Name = "gbAxisY";
            gbAxisY.Size = new Size(350, 180);
            gbAxisY.TabIndex = 3;
            gbAxisY.TabStop = false;
            gbAxisY.Text = "Axis Y";
            // 
            // txtYSpeed
            // 
            txtYSpeed.BackColor = SystemColors.Control;
            txtYSpeed.Location = new Point(160, 112);
            txtYSpeed.Name = "txtYSpeed";
            txtYSpeed.ReadOnly = true;
            txtYSpeed.Size = new Size(160, 23);
            txtYSpeed.TabIndex = 5;
            txtYSpeed.Text = "0.0";
            // 
            // txtYLoading
            // 
            txtYLoading.BackColor = SystemColors.Control;
            txtYLoading.Location = new Point(160, 72);
            txtYLoading.Name = "txtYLoading";
            txtYLoading.ReadOnly = true;
            txtYLoading.Size = new Size(160, 23);
            txtYLoading.TabIndex = 4;
            txtYLoading.Text = "0.00";
            // 
            // txtYCurrent
            // 
            txtYCurrent.BackColor = SystemColors.Control;
            txtYCurrent.Location = new Point(160, 32);
            txtYCurrent.Name = "txtYCurrent";
            txtYCurrent.ReadOnly = true;
            txtYCurrent.Size = new Size(160, 23);
            txtYCurrent.TabIndex = 3;
            txtYCurrent.Text = "0.00";
            // 
            // lblYSpeed
            // 
            lblYSpeed.AutoSize = true;
            lblYSpeed.Location = new Point(20, 115);
            lblYSpeed.Name = "lblYSpeed";
            lblYSpeed.Size = new Size(106, 15);
            lblYSpeed.TabIndex = 2;
            lblYSpeed.Text = "현재 속도 (mm/s):";
            // 
            // lblYLoading
            // 
            lblYLoading.AutoSize = true;
            lblYLoading.Location = new Point(20, 75);
            lblYLoading.Name = "lblYLoading";
            lblYLoading.Size = new Size(96, 15);
            lblYLoading.TabIndex = 1;
            lblYLoading.Text = "로딩 위치 (mm):";
            // 
            // lblYCurrent
            // 
            lblYCurrent.AutoSize = true;
            lblYCurrent.Location = new Point(20, 35);
            lblYCurrent.Name = "lblYCurrent";
            lblYCurrent.Size = new Size(96, 15);
            lblYCurrent.TabIndex = 0;
            lblYCurrent.Text = "현재 위치 (mm):";
            // 
            // gbAxisZ
            // 
            gbAxisZ.Controls.Add(txtZSpeed);
            gbAxisZ.Controls.Add(txtZLoading);
            gbAxisZ.Controls.Add(txtZCurrent);
            gbAxisZ.Controls.Add(lblZSpeed);
            gbAxisZ.Controls.Add(lblZLoading);
            gbAxisZ.Controls.Add(lblZCurrent);
            gbAxisZ.Location = new Point(20, 290);
            gbAxisZ.Name = "gbAxisZ";
            gbAxisZ.Size = new Size(350, 180);
            gbAxisZ.TabIndex = 4;
            gbAxisZ.TabStop = false;
            gbAxisZ.Text = "Axis Z";
            // 
            // txtZSpeed
            // 
            txtZSpeed.BackColor = SystemColors.Control;
            txtZSpeed.Location = new Point(160, 112);
            txtZSpeed.Name = "txtZSpeed";
            txtZSpeed.ReadOnly = true;
            txtZSpeed.Size = new Size(160, 23);
            txtZSpeed.TabIndex = 5;
            txtZSpeed.Text = "0.0";
            // 
            // txtZLoading
            // 
            txtZLoading.BackColor = SystemColors.Control;
            txtZLoading.Location = new Point(160, 72);
            txtZLoading.Name = "txtZLoading";
            txtZLoading.ReadOnly = true;
            txtZLoading.Size = new Size(160, 23);
            txtZLoading.TabIndex = 4;
            txtZLoading.Text = "0.00";
            // 
            // txtZCurrent
            // 
            txtZCurrent.BackColor = SystemColors.Control;
            txtZCurrent.Location = new Point(160, 32);
            txtZCurrent.Name = "txtZCurrent";
            txtZCurrent.ReadOnly = true;
            txtZCurrent.Size = new Size(160, 23);
            txtZCurrent.TabIndex = 3;
            txtZCurrent.Text = "0.00";
            // 
            // lblZSpeed
            // 
            lblZSpeed.AutoSize = true;
            lblZSpeed.Location = new Point(20, 115);
            lblZSpeed.Name = "lblZSpeed";
            lblZSpeed.Size = new Size(106, 15);
            lblZSpeed.TabIndex = 2;
            lblZSpeed.Text = "현재 속도 (mm/s):";
            // 
            // lblZLoading
            // 
            lblZLoading.AutoSize = true;
            lblZLoading.Location = new Point(20, 75);
            lblZLoading.Name = "lblZLoading";
            lblZLoading.Size = new Size(96, 15);
            lblZLoading.TabIndex = 1;
            lblZLoading.Text = "로딩 위치 (mm):";
            // 
            // lblZCurrent
            // 
            lblZCurrent.AutoSize = true;
            lblZCurrent.Location = new Point(20, 35);
            lblZCurrent.Name = "lblZCurrent";
            lblZCurrent.Size = new Size(96, 15);
            lblZCurrent.TabIndex = 0;
            lblZCurrent.Text = "현재 위치 (mm):";
            // 
            // gbAxisT
            // 
            gbAxisT.Controls.Add(txtTSpeed);
            gbAxisT.Controls.Add(txtTLoading);
            gbAxisT.Controls.Add(txtTCurrent);
            gbAxisT.Controls.Add(lblTSpeed);
            gbAxisT.Controls.Add(lblTLoading);
            gbAxisT.Controls.Add(lblTCurrent);
            gbAxisT.Location = new Point(410, 290);
            gbAxisT.Name = "gbAxisT";
            gbAxisT.Size = new Size(350, 180);
            gbAxisT.TabIndex = 5;
            gbAxisT.TabStop = false;
            gbAxisT.Text = "Axis T";
            // 
            // txtTSpeed
            // 
            txtTSpeed.BackColor = SystemColors.Control;
            txtTSpeed.Location = new Point(160, 112);
            txtTSpeed.Name = "txtTSpeed";
            txtTSpeed.ReadOnly = true;
            txtTSpeed.Size = new Size(160, 23);
            txtTSpeed.TabIndex = 5;
            txtTSpeed.Text = "0.0";
            // 
            // txtTLoading
            // 
            txtTLoading.BackColor = SystemColors.Control;
            txtTLoading.Location = new Point(160, 72);
            txtTLoading.Name = "txtTLoading";
            txtTLoading.ReadOnly = true;
            txtTLoading.Size = new Size(160, 23);
            txtTLoading.TabIndex = 4;
            txtTLoading.Text = "0.00";
            // 
            // txtTCurrent
            // 
            txtTCurrent.BackColor = SystemColors.Control;
            txtTCurrent.Location = new Point(160, 32);
            txtTCurrent.Name = "txtTCurrent";
            txtTCurrent.ReadOnly = true;
            txtTCurrent.Size = new Size(160, 23);
            txtTCurrent.TabIndex = 3;
            txtTCurrent.Text = "0.00";
            // 
            // lblTSpeed
            // 
            lblTSpeed.AutoSize = true;
            lblTSpeed.Location = new Point(20, 115);
            lblTSpeed.Name = "lblTSpeed";
            lblTSpeed.Size = new Size(106, 15);
            lblTSpeed.TabIndex = 2;
            lblTSpeed.Text = "현재 속도 (mm/s):";
            // 
            // lblTLoading
            // 
            lblTLoading.AutoSize = true;
            lblTLoading.Location = new Point(20, 75);
            lblTLoading.Name = "lblTLoading";
            lblTLoading.Size = new Size(96, 15);
            lblTLoading.TabIndex = 1;
            lblTLoading.Text = "로딩 위치 (mm):";
            // 
            // lblTCurrent
            // 
            lblTCurrent.AutoSize = true;
            lblTCurrent.Location = new Point(20, 35);
            lblTCurrent.Name = "lblTCurrent";
            lblTCurrent.Size = new Size(96, 15);
            lblTCurrent.TabIndex = 0;
            lblTCurrent.Text = "현재 위치 (mm):";
            // 
            // uiTimer
            // 
            uiTimer.Tick += UiTimer_Tick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 562);
            Controls.Add(pnlContent);
            Controls.Add(pnlBottom);
            Name = "FormMain";
            Text = "FormMain";
            pnlBottom.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            gbAxisX.ResumeLayout(false);
            gbAxisX.PerformLayout();
            gbAxisY.ResumeLayout(false);
            gbAxisY.PerformLayout();
            gbAxisZ.ResumeLayout(false);
            gbAxisZ.PerformLayout();
            gbAxisT.ResumeLayout(false);
            gbAxisT.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBottom = null!;
        private Panel pnlContent = null!;
        private Button btnAuto = null!;
        private Button btnManual = null!;
        private Button btnLog = null!;
        private Button btnSetup = null!;
        private Button btnExit = null!;
        private Label lblTitle = null!;
        private Label lblStatus = null!;
        
        private GroupBox gbAxisX = null!;
        private Label lblXCurrent = null!;
        private TextBox txtXCurrent = null!;
        private Label lblXLoading = null!;
        private TextBox txtXLoading = null!;
        private Label lblXSpeed = null!;
        private TextBox txtXSpeed = null!;

        private GroupBox gbAxisY = null!;
        private Label lblYCurrent = null!;
        private TextBox txtYCurrent = null!;
        private Label lblYLoading = null!;
        private TextBox txtYLoading = null!;
        private Label lblYSpeed = null!;
        private TextBox txtYSpeed = null!;

        private GroupBox gbAxisZ = null!;
        private Label lblZCurrent = null!;
        private TextBox txtZCurrent = null!;
        private Label lblZLoading = null!;
        private TextBox txtZLoading = null!;
        private Label lblZSpeed = null!;
        private TextBox txtZSpeed = null!;

        private GroupBox gbAxisT = null!;
        private Label lblTCurrent = null!;
        private TextBox txtTCurrent = null!;
        private Label lblTLoading = null!;
        private TextBox txtTLoading = null!;
        private Label lblTSpeed = null!;
        private TextBox txtTSpeed = null!;

        private System.Windows.Forms.Timer uiTimer = null!;
    }
}
