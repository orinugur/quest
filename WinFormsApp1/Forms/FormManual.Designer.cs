#nullable enable

using System.Drawing;
using System.Windows.Forms;

namespace QuestProject.Forms
{
    partial class FormManual
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label9 = new Label();
            gbAxisSelection = new GroupBox();
            rbAxisT = new RadioButton();
            rbAxisZ = new RadioButton();
            rbAxisY = new RadioButton();
            rbAxisX = new RadioButton();
            gbMotionParams = new GroupBox();
            numTargetPosition = new NumericUpDown();
            numSpeed = new NumericUpDown();
            txtCurrentPosition = new TextBox();
            lblTargetPosition = new Label();
            lblSpeed = new Label();
            lblCurrentPosition = new Label();
            gbMoveMode = new GroupBox();
            rbRelative = new RadioButton();
            rbAbsolute = new RadioButton();
            gbActions = new GroupBox();
            btnSyncMove = new Button();
            btnAsyncMove = new Button();
            uiTimer = new System.Windows.Forms.Timer(components);
            gbAxisSelection.SuspendLayout();
            gbMotionParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTargetPosition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSpeed).BeginInit();
            gbMoveMode.SuspendLayout();
            gbActions.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("맑은 고딕", 20F);
            label9.Location = new Point(12, 9);
            label9.Name = "label9";
            label9.Size = new Size(109, 37);
            label9.TabIndex = 3;
            label9.Text = "Manual";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // gbAxisSelection
            // 
            gbAxisSelection.Controls.Add(rbAxisT);
            gbAxisSelection.Controls.Add(rbAxisZ);
            gbAxisSelection.Controls.Add(rbAxisY);
            gbAxisSelection.Controls.Add(rbAxisX);
            gbAxisSelection.Location = new Point(15, 60);
            gbAxisSelection.Name = "gbAxisSelection";
            gbAxisSelection.Size = new Size(150, 220);
            gbAxisSelection.TabIndex = 4;
            gbAxisSelection.TabStop = false;
            gbAxisSelection.Text = "축 선택";
            // 
            // rbAxisT
            // 
            rbAxisT.AutoSize = true;
            rbAxisT.Location = new Point(20, 165);
            rbAxisT.Name = "rbAxisT";
            rbAxisT.Size = new Size(57, 19);
            rbAxisT.TabIndex = 3;
            rbAxisT.Text = "Axis T";
            rbAxisT.UseVisualStyleBackColor = true;
            // 
            // rbAxisZ
            // 
            rbAxisZ.AutoSize = true;
            rbAxisZ.Location = new Point(20, 120);
            rbAxisZ.Name = "rbAxisZ";
            rbAxisZ.Size = new Size(58, 19);
            rbAxisZ.TabIndex = 2;
            rbAxisZ.Text = "Axis Z";
            rbAxisZ.UseVisualStyleBackColor = true;
            // 
            // rbAxisY
            // 
            rbAxisY.AutoSize = true;
            rbAxisY.Location = new Point(20, 75);
            rbAxisY.Name = "rbAxisY";
            rbAxisY.Size = new Size(58, 19);
            rbAxisY.TabIndex = 1;
            rbAxisY.Text = "Axis Y";
            rbAxisY.UseVisualStyleBackColor = true;
            // 
            // rbAxisX
            // 
            rbAxisX.AutoSize = true;
            rbAxisX.Checked = true;
            rbAxisX.Location = new Point(20, 30);
            rbAxisX.Name = "rbAxisX";
            rbAxisX.Size = new Size(59, 19);
            rbAxisX.TabIndex = 0;
            rbAxisX.TabStop = true;
            rbAxisX.Text = "Axis X";
            rbAxisX.UseVisualStyleBackColor = true;
            // 
            // gbMotionParams
            // 
            gbMotionParams.Controls.Add(numTargetPosition);
            gbMotionParams.Controls.Add(numSpeed);
            gbMotionParams.Controls.Add(txtCurrentPosition);
            gbMotionParams.Controls.Add(lblTargetPosition);
            gbMotionParams.Controls.Add(lblSpeed);
            gbMotionParams.Controls.Add(lblCurrentPosition);
            gbMotionParams.Location = new Point(180, 60);
            gbMotionParams.Name = "gbMotionParams";
            gbMotionParams.Size = new Size(280, 220);
            gbMotionParams.TabIndex = 5;
            gbMotionParams.TabStop = false;
            gbMotionParams.Text = "이동 설정 및 모니터링";
            // 
            // numTargetPosition
            // 
            numTargetPosition.DecimalPlaces = 2;
            numTargetPosition.Location = new Point(130, 117);
            numTargetPosition.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numTargetPosition.Minimum = new decimal(new int[] { 10000, 0, 0, -2147483648 });
            numTargetPosition.Name = "numTargetPosition";
            numTargetPosition.Size = new Size(130, 23);
            numTargetPosition.TabIndex = 5;
            // 
            // numSpeed
            // 
            numSpeed.DecimalPlaces = 2;
            numSpeed.Location = new Point(130, 72);
            numSpeed.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numSpeed.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            numSpeed.Name = "numSpeed";
            numSpeed.Size = new Size(130, 23);
            numSpeed.TabIndex = 4;
            numSpeed.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // txtCurrentPosition
            // 
            txtCurrentPosition.BackColor = SystemColors.Control;
            txtCurrentPosition.Location = new Point(130, 27);
            txtCurrentPosition.Name = "txtCurrentPosition";
            txtCurrentPosition.ReadOnly = true;
            txtCurrentPosition.Size = new Size(130, 23);
            txtCurrentPosition.TabIndex = 3;
            txtCurrentPosition.Text = "0.00";
            // 
            // lblTargetPosition
            // 
            lblTargetPosition.AutoSize = true;
            lblTargetPosition.Location = new Point(15, 120);
            lblTargetPosition.Name = "lblTargetPosition";
            lblTargetPosition.Size = new Size(94, 15);
            lblTargetPosition.TabIndex = 2;
            lblTargetPosition.Text = "목표 위치 (mm):";
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Location = new Point(15, 75);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(79, 15);
            lblSpeed.TabIndex = 1;
            lblSpeed.Text = "속도 (mm/s):";
            // 
            // lblCurrentPosition
            // 
            lblCurrentPosition.AutoSize = true;
            lblCurrentPosition.Location = new Point(15, 30);
            lblCurrentPosition.Name = "lblCurrentPosition";
            lblCurrentPosition.Size = new Size(94, 15);
            lblCurrentPosition.TabIndex = 0;
            lblCurrentPosition.Text = "현재 위치 (mm):";
            // 
            // gbMoveMode
            // 
            gbMoveMode.Controls.Add(rbRelative);
            gbMoveMode.Controls.Add(rbAbsolute);
            gbMoveMode.Location = new Point(480, 60);
            gbMoveMode.Name = "gbMoveMode";
            gbMoveMode.Size = new Size(250, 100);
            gbMoveMode.TabIndex = 6;
            gbMoveMode.TabStop = false;
            gbMoveMode.Text = "이동 모드";
            // 
            // rbRelative
            // 
            rbRelative.AutoSize = true;
            rbRelative.Location = new Point(20, 65);
            rbRelative.Name = "rbRelative";
            rbRelative.Size = new Size(138, 19);
            rbRelative.TabIndex = 1;
            rbRelative.Text = "상대 위치 (Relative)";
            rbRelative.UseVisualStyleBackColor = true;
            // 
            // rbAbsolute
            // 
            rbAbsolute.AutoSize = true;
            rbAbsolute.Checked = true;
            rbAbsolute.Location = new Point(20, 30);
            rbAbsolute.Name = "rbAbsolute";
            rbAbsolute.Size = new Size(141, 19);
            rbAbsolute.TabIndex = 0;
            rbAbsolute.TabStop = true;
            rbAbsolute.Text = "절대 위치 (Absolute)";
            rbAbsolute.UseVisualStyleBackColor = true;
            // 
            // gbActions
            // 
            gbActions.Controls.Add(btnSyncMove);
            gbActions.Controls.Add(btnAsyncMove);
            gbActions.Location = new Point(480, 170);
            gbActions.Name = "gbActions";
            gbActions.Size = new Size(250, 110);
            gbActions.TabIndex = 7;
            gbActions.TabStop = false;
            gbActions.Text = "축 이동 제어";
            // 
            // btnSyncMove
            // 
            btnSyncMove.Location = new Point(20, 65);
            btnSyncMove.Name = "btnSyncMove";
            btnSyncMove.Size = new Size(210, 32);
            btnSyncMove.TabIndex = 1;
            btnSyncMove.Text = "동기 이동";
            btnSyncMove.UseVisualStyleBackColor = true;
            // 
            // btnAsyncMove
            // 
            btnAsyncMove.Location = new Point(20, 25);
            btnAsyncMove.Name = "btnAsyncMove";
            btnAsyncMove.Size = new Size(210, 32);
            btnAsyncMove.TabIndex = 0;
            btnAsyncMove.Text = "비동기 이동";
            btnAsyncMove.UseVisualStyleBackColor = true;
            // 
            // uiTimer
            // 
            uiTimer.Enabled = true;
            uiTimer.Interval = 100;
            // 
            // FormManual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbActions);
            Controls.Add(gbMoveMode);
            Controls.Add(gbMotionParams);
            Controls.Add(gbAxisSelection);
            Controls.Add(label9);
            Name = "FormManual";
            Text = "FormManual";
            gbAxisSelection.ResumeLayout(false);
            gbAxisSelection.PerformLayout();
            gbMotionParams.ResumeLayout(false);
            gbMotionParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTargetPosition).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSpeed).EndInit();
            gbMoveMode.ResumeLayout(false);
            gbMoveMode.PerformLayout();
            gbActions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9 = null!;
        private GroupBox gbAxisSelection = null!;
        private RadioButton rbAxisT = null!;
        private RadioButton rbAxisZ = null!;
        private RadioButton rbAxisY = null!;
        private RadioButton rbAxisX = null!;
        private GroupBox gbMotionParams = null!;
        private NumericUpDown numTargetPosition = null!;
        private NumericUpDown numSpeed = null!;
        private TextBox txtCurrentPosition = null!;
        private Label lblTargetPosition = null!;
        private Label lblSpeed = null!;
        private Label lblCurrentPosition = null!;
        private GroupBox gbMoveMode = null!;
        private RadioButton rbRelative = null!;
        private RadioButton rbAbsolute = null!;
        private GroupBox gbActions = null!;
        private Button btnSyncMove = null!;
        private Button btnAsyncMove = null!;
        private System.Windows.Forms.Timer uiTimer = null!;
    }
}
