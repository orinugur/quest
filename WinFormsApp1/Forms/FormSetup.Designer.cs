#nullable enable

using System.Drawing;
using System.Windows.Forms;

namespace QuestProject.Forms
{
    partial class FormSetup
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
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox4 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            tabPage2 = new TabPage();
            label2 = new Label();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            numericUpDown3 = new NumericUpDown();
            label4 = new Label();
            numericUpDown4 = new NumericUpDown();
            label5 = new Label();
            numericUpDown5 = new NumericUpDown();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
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
            tabPage1.Controls.Add(groupBox4);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(762, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "축 설정";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Location = new Point(9, 270);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(750, 82);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Axis T";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(6, 182);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(750, 82);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Axis Z";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(6, 94);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(750, 82);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Axis Y";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(numericUpDown5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numericUpDown4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(numericUpDown3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(750, 82);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Axis X";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 1;
            label1.Text = "Loading Postion";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(6, 41);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(94, 23);
            numericUpDown1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(762, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "기타";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(306, 23);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Speed";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(306, 41);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(94, 23);
            numericUpDown2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 23);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Liimit (+)";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(106, 41);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(94, 23);
            numericUpDown3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(206, 23);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 7;
            label4.Text = "Liimit (-)";
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(206, 41);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(94, 23);
            numericUpDown4.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(406, 23);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 9;
            label5.Text = "Max Speed";
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(406, 41);
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(94, 23);
            numericUpDown5.TabIndex = 8;
            numericUpDown5.ValueChanged += numericUpDown5_ValueChanged;
            // 
            // FormSetup
            // 
            ClientSize = new Size(800, 530);
            Controls.Add(tabControl1);
            Name = "FormSetup";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl? tabControl1;
        private TabPage? tabPage1;
        private TabPage? tabPage2;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private NumericUpDown numericUpDown2;
        private Label label5;
        private NumericUpDown numericUpDown5;
        private Label label4;
        private NumericUpDown numericUpDown4;
        private Label label3;
        private NumericUpDown numericUpDown3;
    }
}
