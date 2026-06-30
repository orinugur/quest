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
            button1 = new Button();
            btnSaveAxis = new Button();
            groupBox3 = new GroupBox();
            label13 = new Label();
            numericUpDown13 = new NumericUpDown();
            label14 = new Label();
            numericUpDown14 = new NumericUpDown();
            label15 = new Label();
            numericUpDown15 = new NumericUpDown();
            label16 = new Label();
            numericUpDown16 = new NumericUpDown();
            label17 = new Label();
            numericUpDown17 = new NumericUpDown();
            label18 = new Label();
            numericUpDown18 = new NumericUpDown();
            groupBox4 = new GroupBox();
            label19 = new Label();
            numericUpDown19 = new NumericUpDown();
            label20 = new Label();
            numericUpDown20 = new NumericUpDown();
            label21 = new Label();
            numericUpDown21 = new NumericUpDown();
            label22 = new Label();
            numericUpDown22 = new NumericUpDown();
            label23 = new Label();
            numericUpDown23 = new NumericUpDown();
            label24 = new Label();
            numericUpDown24 = new NumericUpDown();
            groupBox1 = new GroupBox();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            numericUpDown3 = new NumericUpDown();
            label4 = new Label();
            numericUpDown4 = new NumericUpDown();
            label5 = new Label();
            numericUpDown5 = new NumericUpDown();
            label12 = new Label();
            numericUpDown12 = new NumericUpDown();
            groupBox2 = new GroupBox();
            label11 = new Label();
            numericUpDown11 = new NumericUpDown();
            label6 = new Label();
            numericUpDown6 = new NumericUpDown();
            label7 = new Label();
            numericUpDown7 = new NumericUpDown();
            label8 = new Label();
            numericUpDown8 = new NumericUpDown();
            label9 = new Label();
            numericUpDown9 = new NumericUpDown();
            label10 = new Label();
            numericUpDown10 = new NumericUpDown();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown18).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown19).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown22).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown23).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown24).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown12).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown10).BeginInit();
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
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(btnSaveAxis);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox4);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(762, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "축 설정";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            button1.Location = new Point(96, 250);
            button1.Name = "button1";
            button1.Size = new Size(84, 40);
            button1.TabIndex = 15;
            button1.Text = "ＬＯＡＤ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSaveAxis
            // 
            btnSaveAxis.BackColor = Color.SkyBlue;
            btnSaveAxis.FlatStyle = FlatStyle.Flat;
            btnSaveAxis.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btnSaveAxis.Location = new Point(6, 250);
            btnSaveAxis.Name = "btnSaveAxis";
            btnSaveAxis.Size = new Size(84, 40);
            btnSaveAxis.TabIndex = 14;
            btnSaveAxis.Text = "ＳＡＶＥ";
            btnSaveAxis.UseVisualStyleBackColor = false;
            btnSaveAxis.Click += btnSaveAxis_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(numericUpDown13);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(numericUpDown14);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(numericUpDown15);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(numericUpDown16);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(numericUpDown17);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(numericUpDown18);
            groupBox3.Location = new Point(326, 123);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(306, 111);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Axis Ｔ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 64);
            label13.Name = "label13";
            label13.Size = new Size(94, 15);
            label13.TabIndex = 11;
            label13.Text = "Current Position";
            // 
            // numericUpDown13
            // 
            numericUpDown13.Location = new Point(6, 82);
            numericUpDown13.Name = "numericUpDown13";
            numericUpDown13.Size = new Size(94, 23);
            numericUpDown13.TabIndex = 10;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(206, 64);
            label14.Name = "label14";
            label14.Size = new Size(67, 15);
            label14.TabIndex = 9;
            label14.Text = "Max Speed";
            // 
            // numericUpDown14
            // 
            numericUpDown14.Location = new Point(206, 82);
            numericUpDown14.Name = "numericUpDown14";
            numericUpDown14.Size = new Size(94, 23);
            numericUpDown14.TabIndex = 8;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(106, 64);
            label15.Name = "label15";
            label15.Size = new Size(51, 15);
            label15.TabIndex = 7;
            label15.Text = "Limit (-)";
            // 
            // numericUpDown15
            // 
            numericUpDown15.Location = new Point(106, 82);
            numericUpDown15.Name = "numericUpDown15";
            numericUpDown15.Size = new Size(94, 23);
            numericUpDown15.TabIndex = 6;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(106, 19);
            label16.Name = "label16";
            label16.Size = new Size(54, 15);
            label16.TabIndex = 5;
            label16.Text = "Limit (+)";
            // 
            // numericUpDown16
            // 
            numericUpDown16.Location = new Point(106, 37);
            numericUpDown16.Name = "numericUpDown16";
            numericUpDown16.Size = new Size(94, 23);
            numericUpDown16.TabIndex = 4;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(206, 19);
            label17.Name = "label17";
            label17.Size = new Size(40, 15);
            label17.TabIndex = 3;
            label17.Text = "Speed";
            // 
            // numericUpDown17
            // 
            numericUpDown17.Location = new Point(206, 37);
            numericUpDown17.Name = "numericUpDown17";
            numericUpDown17.Size = new Size(94, 23);
            numericUpDown17.TabIndex = 2;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 19);
            label18.Name = "label18";
            label18.Size = new Size(97, 15);
            label18.TabIndex = 1;
            label18.Text = "Loading Position";
            // 
            // numericUpDown18
            // 
            numericUpDown18.Location = new Point(6, 37);
            numericUpDown18.Name = "numericUpDown18";
            numericUpDown18.Size = new Size(94, 23);
            numericUpDown18.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label19);
            groupBox4.Controls.Add(numericUpDown19);
            groupBox4.Controls.Add(label20);
            groupBox4.Controls.Add(numericUpDown20);
            groupBox4.Controls.Add(label21);
            groupBox4.Controls.Add(numericUpDown21);
            groupBox4.Controls.Add(label22);
            groupBox4.Controls.Add(numericUpDown22);
            groupBox4.Controls.Add(label23);
            groupBox4.Controls.Add(numericUpDown23);
            groupBox4.Controls.Add(label24);
            groupBox4.Controls.Add(numericUpDown24);
            groupBox4.Location = new Point(6, 123);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(306, 111);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Axis Ｚ";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(6, 64);
            label19.Name = "label19";
            label19.Size = new Size(94, 15);
            label19.TabIndex = 11;
            label19.Text = "Current Position";
            // 
            // numericUpDown19
            // 
            numericUpDown19.Location = new Point(6, 82);
            numericUpDown19.Name = "numericUpDown19";
            numericUpDown19.Size = new Size(94, 23);
            numericUpDown19.TabIndex = 10;
            numericUpDown19.UpDownAlign = LeftRightAlignment.Left;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(206, 64);
            label20.Name = "label20";
            label20.Size = new Size(67, 15);
            label20.TabIndex = 9;
            label20.Text = "Max Speed";
            // 
            // numericUpDown20
            // 
            numericUpDown20.Location = new Point(206, 82);
            numericUpDown20.Name = "numericUpDown20";
            numericUpDown20.Size = new Size(94, 23);
            numericUpDown20.TabIndex = 8;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(106, 64);
            label21.Name = "label21";
            label21.Size = new Size(51, 15);
            label21.TabIndex = 7;
            label21.Text = "Limit (-)";
            // 
            // numericUpDown21
            // 
            numericUpDown21.Location = new Point(106, 82);
            numericUpDown21.Name = "numericUpDown21";
            numericUpDown21.Size = new Size(94, 23);
            numericUpDown21.TabIndex = 6;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(106, 19);
            label22.Name = "label22";
            label22.Size = new Size(54, 15);
            label22.TabIndex = 5;
            label22.Text = "Limit (+)";
            // 
            // numericUpDown22
            // 
            numericUpDown22.Location = new Point(106, 37);
            numericUpDown22.Name = "numericUpDown22";
            numericUpDown22.Size = new Size(94, 23);
            numericUpDown22.TabIndex = 4;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(206, 19);
            label23.Name = "label23";
            label23.Size = new Size(40, 15);
            label23.TabIndex = 3;
            label23.Text = "Speed";
            // 
            // numericUpDown23
            // 
            numericUpDown23.Location = new Point(206, 37);
            numericUpDown23.Name = "numericUpDown23";
            numericUpDown23.Size = new Size(94, 23);
            numericUpDown23.TabIndex = 2;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(6, 19);
            label24.Name = "label24";
            label24.Size = new Size(97, 15);
            label24.TabIndex = 1;
            label24.Text = "Loading Position";
            // 
            // numericUpDown24
            // 
            numericUpDown24.Location = new Point(6, 37);
            numericUpDown24.Name = "numericUpDown24";
            numericUpDown24.Size = new Size(94, 23);
            numericUpDown24.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(numericUpDown3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numericUpDown4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(numericUpDown5);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(numericUpDown12);
            groupBox1.Location = new Point(326, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(306, 111);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Axis Ｙ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 64);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 11;
            label1.Text = "Current Position";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(6, 82);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(94, 23);
            numericUpDown1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 64);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 9;
            label2.Text = "Max Speed";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(206, 82);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(94, 23);
            numericUpDown2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 64);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 7;
            label3.Text = "Limit (-)";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(106, 82);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(94, 23);
            numericUpDown3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 19);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 5;
            label4.Text = "Limit (+)";
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(106, 37);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(94, 23);
            numericUpDown4.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(206, 19);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 3;
            label5.Text = "Speed";
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(206, 37);
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(94, 23);
            numericUpDown5.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 19);
            label12.Name = "label12";
            label12.Size = new Size(97, 15);
            label12.TabIndex = 1;
            label12.Text = "Loading Position";
            // 
            // numericUpDown12
            // 
            numericUpDown12.Location = new Point(6, 37);
            numericUpDown12.Name = "numericUpDown12";
            numericUpDown12.Size = new Size(94, 23);
            numericUpDown12.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(numericUpDown11);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(numericUpDown6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(numericUpDown7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(numericUpDown8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(numericUpDown9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(numericUpDown10);
            groupBox2.Location = new Point(6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(306, 111);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Axis X";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 64);
            label11.Name = "label11";
            label11.Size = new Size(94, 15);
            label11.TabIndex = 11;
            label11.Text = "Current Position";
            // 
            // numericUpDown11
            // 
            numericUpDown11.Location = new Point(6, 82);
            numericUpDown11.Name = "numericUpDown11";
            numericUpDown11.Size = new Size(94, 23);
            numericUpDown11.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(206, 64);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 9;
            label6.Text = "Max Speed";
            // 
            // numericUpDown6
            // 
            numericUpDown6.Location = new Point(206, 82);
            numericUpDown6.Name = "numericUpDown6";
            numericUpDown6.Size = new Size(94, 23);
            numericUpDown6.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(106, 64);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 7;
            label7.Text = "Limit (-)";
            label7.Click += label7_Click;
            // 
            // numericUpDown7
            // 
            numericUpDown7.Location = new Point(106, 82);
            numericUpDown7.Name = "numericUpDown7";
            numericUpDown7.Size = new Size(94, 23);
            numericUpDown7.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(106, 19);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 5;
            label8.Text = "Limit (+)";
            // 
            // numericUpDown8
            // 
            numericUpDown8.Location = new Point(106, 37);
            numericUpDown8.Name = "numericUpDown8";
            numericUpDown8.Size = new Size(94, 23);
            numericUpDown8.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(206, 19);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 3;
            label9.Text = "Speed";
            // 
            // numericUpDown9
            // 
            numericUpDown9.Location = new Point(206, 37);
            numericUpDown9.Name = "numericUpDown9";
            numericUpDown9.Size = new Size(94, 23);
            numericUpDown9.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 19);
            label10.Name = "label10";
            label10.Size = new Size(97, 15);
            label10.TabIndex = 1;
            label10.Text = "Loading Position";
            // 
            // numericUpDown10
            // 
            numericUpDown10.Location = new Point(6, 37);
            numericUpDown10.Name = "numericUpDown10";
            numericUpDown10.Size = new Size(94, 23);
            numericUpDown10.TabIndex = 0;
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
            // FormSetup
            // 
            ClientSize = new Size(800, 530);
            Controls.Add(tabControl1);
            Name = "FormSetup";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown13).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown14).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown15).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown16).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown17).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown18).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown19).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown20).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown21).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown22).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown23).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown24).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown12).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown11).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown7).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown8).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown9).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown10).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl? tabControl1;
        private TabPage? tabPage1;
        private TabPage? tabPage2;
        private GroupBox groupBox2;
        private Label label6;
        private NumericUpDown numericUpDown6;
        private Label label7;
        private NumericUpDown numericUpDown7;
        private Label label8;
        private NumericUpDown numericUpDown8;
        private Label label9;
        private NumericUpDown numericUpDown9;
        private Label label10;
        private NumericUpDown numericUpDown10;
        private Label label11;
        private NumericUpDown numericUpDown11;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Label label13;
        private NumericUpDown numericUpDown13;
        private Label label14;
        private NumericUpDown numericUpDown14;
        private Label label15;
        private NumericUpDown numericUpDown15;
        private Label label16;
        private NumericUpDown numericUpDown16;
        private Label label17;
        private NumericUpDown numericUpDown17;
        private Label label18;
        private NumericUpDown numericUpDown18;
        private Label label19;
        private NumericUpDown numericUpDown19;
        private Label label20;
        private NumericUpDown numericUpDown20;
        private Label label21;
        private NumericUpDown numericUpDown21;
        private Label label22;
        private NumericUpDown numericUpDown22;
        private Label label23;
        private NumericUpDown numericUpDown23;
        private Label label24;
        private NumericUpDown numericUpDown24;
        private GroupBox groupBox1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private NumericUpDown numericUpDown2;
        private Label label3;
        private NumericUpDown numericUpDown3;
        private Label label4;
        private NumericUpDown numericUpDown4;
        private Label label5;
        private NumericUpDown numericUpDown5;
        private Label label12;
        private NumericUpDown numericUpDown12;
        private Button btnSaveAxis;
        private Button button1;
    }
}
