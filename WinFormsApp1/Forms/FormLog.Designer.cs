namespace QuestProject.Forms
{
    partial class FormLog
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
            label9 = new Label();
            dtpLogDate = new DateTimePicker();
            pnlTopBar = new Panel();
            btnQuery = new Button();
            lblSelectDate = new Label();
            txtLogOutput = new TextBox();
            pnlTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("¸¼Àº °íµñ", 20F);
            label9.Location = new Point(12, 9);
            label9.Name = "label9";
            label9.Size = new Size(62, 37);
            label9.TabIndex = 4;
            label9.Text = "Log";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // dtpLogDate
            // 
            dtpLogDate.Font = new Font("¸¼Àº °íµñ", 9.75F);
            dtpLogDate.Location = new Point(120, 12);
            dtpLogDate.Name = "dtpLogDate";
            dtpLogDate.Size = new Size(200, 25);
            dtpLogDate.TabIndex = 1;
            // 
            // pnlTopBar
            // 
            pnlTopBar.Controls.Add(btnQuery);
            pnlTopBar.Controls.Add(dtpLogDate);
            pnlTopBar.Controls.Add(lblSelectDate);
            pnlTopBar.Location = new Point(18, 49);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(770, 50);
            pnlTopBar.TabIndex = 5;
            // 
            // btnQuery
            // 
            btnQuery.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnQuery.BackColor = Color.White;
            btnQuery.FlatStyle = FlatStyle.Flat;
            btnQuery.Font = new Font("¸¼Àº °íµñ", 9.75F, FontStyle.Bold);
            btnQuery.Location = new Point(326, 9);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new Size(100, 30);
            btnQuery.TabIndex = 2;
            btnQuery.Text = "Á¶È¸ (SEARCH)";
            btnQuery.UseVisualStyleBackColor = false;
            // 
            // lblSelectDate
            // 
            lblSelectDate.AutoSize = true;
            lblSelectDate.Font = new Font("¸¼Àº °íµñ", 9.75F, FontStyle.Bold);
            lblSelectDate.Location = new Point(15, 16);
            lblSelectDate.Name = "lblSelectDate";
            lblSelectDate.Size = new Size(96, 17);
            lblSelectDate.TabIndex = 0;
            lblSelectDate.Text = "Á¶È¸ ³¯Â¥ ¼±ÅÃ";
            // 
            // txtLogOutput
            // 
            txtLogOutput.BackColor = Color.FromArgb(30, 30, 30);
            txtLogOutput.Font = new Font("Consolas", 9.75F);
            txtLogOutput.ForeColor = Color.LightGray;
            txtLogOutput.Location = new Point(18, 105);
            txtLogOutput.Multiline = true;
            txtLogOutput.Name = "txtLogOutput";
            txtLogOutput.ReadOnly = true;
            txtLogOutput.ScrollBars = ScrollBars.Vertical;
            txtLogOutput.Size = new Size(770, 293);
            txtLogOutput.TabIndex = 7;
            // 
            // FormLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLogOutput);
            Controls.Add(pnlTopBar);
            Controls.Add(label9);
            Name = "FormLog";
            Text = "FormLog";
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private DateTimePicker dtpLogDate;
        private Panel pnlTopBar;
        private Button btnQuery;
        private Label lblSelectDate;
        private TextBox txtLogOutput;
    }
}
