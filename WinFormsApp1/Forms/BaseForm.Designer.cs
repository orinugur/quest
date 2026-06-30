#nullable enable

using System.Drawing;
using System.Windows.Forms;

namespace QuestProject.Forms
{
    partial class BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer? components = null;

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
        private void InitializeBaseComponent()
        {
            this.lblTitle = new Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTitle.Location = new Point(15, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(150, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Page Title";
            this.lblTitle.ForeColor = Color.Black;
            // 
            // BaseForm
            // 
            this.ClientSize = new Size(800, 600);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(this.lblTitle);
            this.Name = "BaseForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        protected Label? lblTitle;
    }
}
