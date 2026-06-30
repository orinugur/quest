using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using QuestProject.Common;

namespace QuestProject.Forms
{
    public partial class FormSetup : Form
    {
        public FormSetup()
        {
            InitializeComponent();
            this.Load += FormSetup_Load; // 폼 로드 이벤트 직접 등록
        }

        private void FormSetup_Load(object sender, EventArgs e)
        {
            string defaultPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.ini");
            if (File.Exists(defaultPath))
            {
                LoadSettings(defaultPath);
            }
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
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                saveFileDialog.Filter = "INI 파일 (*.ini)|*.ini|모든 파일 (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.FileName = "config.ini"; // 기본 파일명 지정

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = saveFileDialog.FileName;
                    SaveSettings(selectedFilePath);
                    MessageBox.Show("환경설정이 저장되었습니다.", "저장 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                openFileDialog.Filter = "INI 파일 (*.ini)|*.ini|모든 파일 (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    LoadSettings(selectedFilePath);
                    MessageBox.Show("환경설정이 로드되었습니다.", "로드 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void SaveSettings(string filePath)
        {
            try
            {
                var data = new Dictionary<string, Dictionary<string, string>>(StringComparer.OrdinalIgnoreCase);

                // Axis X (groupBox2)
                data["Axis X"] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                    { "CurrentPosition", numericUpDown11.Value.ToString() },
                    { "MaxSpeed", numericUpDown6.Value.ToString() },
                    { "LimitMin", numericUpDown7.Value.ToString() },
                    { "LimitMax", numericUpDown8.Value.ToString() },
                    { "Speed", numericUpDown9.Value.ToString() },
                    { "LoadingPosition", numericUpDown10.Value.ToString() }
                };

                // Axis Y (groupBox1)
                data["Axis Y"] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                    { "CurrentPosition", numericUpDown1.Value.ToString() },
                    { "MaxSpeed", numericUpDown2.Value.ToString() },
                    { "LimitMin", numericUpDown3.Value.ToString() },
                    { "LimitMax", numericUpDown4.Value.ToString() },
                    { "Speed", numericUpDown5.Value.ToString() },
                    { "LoadingPosition", numericUpDown12.Value.ToString() }
                };

                // Axis Z (groupBox4)
                data["Axis Z"] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                    { "CurrentPosition", numericUpDown19.Value.ToString() },
                    { "MaxSpeed", numericUpDown20.Value.ToString() },
                    { "LimitMin", numericUpDown21.Value.ToString() },
                    { "LimitMax", numericUpDown22.Value.ToString() },
                    { "Speed", numericUpDown23.Value.ToString() },
                    { "LoadingPosition", numericUpDown24.Value.ToString() }
                };

                // Axis T (groupBox3)
                data["Axis T"] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                    { "CurrentPosition", numericUpDown13.Value.ToString() },
                    { "MaxSpeed", numericUpDown14.Value.ToString() },
                    { "LimitMin", numericUpDown15.Value.ToString() },
                    { "LimitMax", numericUpDown16.Value.ToString() },
                    { "Speed", numericUpDown17.Value.ToString() },
                    { "LoadingPosition", numericUpDown18.Value.ToString() }
                };

                IniHelper.Save(filePath, data);
                UpdateGlobalData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"설정을 저장하는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSettings(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                    return;

                var data = IniHelper.Load(filePath);

                // Axis X (groupBox2)
                if (data.TryGetValue("Axis X", out var axisX))
                {
                    if (axisX.TryGetValue("CurrentPosition", out var val) && decimal.TryParse(val, out var dVal)) numericUpDown11.Value = dVal;
                    if (axisX.TryGetValue("MaxSpeed", out var valMaxSpeed) && decimal.TryParse(valMaxSpeed, out var dMaxSpeed)) numericUpDown6.Value = dMaxSpeed;
                    if (axisX.TryGetValue("LimitMin", out var valLimitMin) && decimal.TryParse(valLimitMin, out var dLimitMin)) numericUpDown7.Value = dLimitMin;
                    if (axisX.TryGetValue("LimitMax", out var valLimitMax) && decimal.TryParse(valLimitMax, out var dLimitMax)) numericUpDown8.Value = dLimitMax;
                    if (axisX.TryGetValue("Speed", out var valSpeed) && decimal.TryParse(valSpeed, out var dSpeed)) numericUpDown9.Value = dSpeed;
                    if (axisX.TryGetValue("LoadingPosition", out var valLoading) && decimal.TryParse(valLoading, out var dLoading)) numericUpDown10.Value = dLoading;
                }

                // Axis Y (groupBox1)
                if (data.TryGetValue("Axis Y", out var axisY))
                {
                    if (axisY.TryGetValue("CurrentPosition", out var val) && decimal.TryParse(val, out var dVal)) numericUpDown1.Value = dVal;
                    if (axisY.TryGetValue("MaxSpeed", out var valMaxSpeed) && decimal.TryParse(valMaxSpeed, out var dMaxSpeed)) numericUpDown2.Value = dMaxSpeed;
                    if (axisY.TryGetValue("LimitMin", out var valLimitMin) && decimal.TryParse(valLimitMin, out var dLimitMin)) numericUpDown3.Value = dLimitMin;
                    if (axisY.TryGetValue("LimitMax", out var valLimitMax) && decimal.TryParse(valLimitMax, out var dLimitMax)) numericUpDown4.Value = dLimitMax;
                    if (axisY.TryGetValue("Speed", out var valSpeed) && decimal.TryParse(valSpeed, out var dSpeed)) numericUpDown5.Value = dSpeed;
                    if (axisY.TryGetValue("LoadingPosition", out var valLoading) && decimal.TryParse(valLoading, out var dLoading)) numericUpDown12.Value = dLoading;
                }

                // Axis Z (groupBox4)
                if (data.TryGetValue("Axis Z", out var axisZ))
                {
                    if (axisZ.TryGetValue("CurrentPosition", out var val) && decimal.TryParse(val, out var dVal)) numericUpDown19.Value = dVal;
                    if (axisZ.TryGetValue("MaxSpeed", out var valMaxSpeed) && decimal.TryParse(valMaxSpeed, out var dMaxSpeed)) numericUpDown20.Value = dMaxSpeed;
                    if (axisZ.TryGetValue("LimitMin", out var valLimitMin) && decimal.TryParse(valLimitMin, out var dLimitMin)) numericUpDown21.Value = dLimitMin;
                    if (axisZ.TryGetValue("LimitMax", out var valLimitMax) && decimal.TryParse(valLimitMax, out var dLimitMax)) numericUpDown22.Value = dLimitMax;
                    if (axisZ.TryGetValue("Speed", out var valSpeed) && decimal.TryParse(valSpeed, out var dSpeed)) numericUpDown23.Value = dSpeed;
                    if (axisZ.TryGetValue("LoadingPosition", out var valLoading) && decimal.TryParse(valLoading, out var dLoading)) numericUpDown24.Value = dLoading;
                }

                // Axis T (groupBox3)
                if (data.TryGetValue("Axis T", out var axisT))
                {
                    if (axisT.TryGetValue("CurrentPosition", out var val) && decimal.TryParse(val, out var dVal)) numericUpDown13.Value = dVal;
                    if (axisT.TryGetValue("MaxSpeed", out var valMaxSpeed) && decimal.TryParse(valMaxSpeed, out var dMaxSpeed)) numericUpDown14.Value = dMaxSpeed;
                    if (axisT.TryGetValue("LimitMin", out var valLimitMin) && decimal.TryParse(valLimitMin, out var dLimitMin)) numericUpDown15.Value = dLimitMin;
                    if (axisT.TryGetValue("LimitMax", out var valLimitMax) && decimal.TryParse(valLimitMax, out var dLimitMax)) numericUpDown16.Value = dLimitMax;
                    if (axisT.TryGetValue("Speed", out var valSpeed) && decimal.TryParse(valSpeed, out var dSpeed)) numericUpDown17.Value = dSpeed;
                    if (axisT.TryGetValue("LoadingPosition", out var valLoading) && decimal.TryParse(valLoading, out var dLoading)) numericUpDown18.Value = dLoading;
                }

                UpdateGlobalData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"설정을 로드하는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateGlobalData()
        {
            // Axis X
            GlobalData.AxisX.CurrentPosition = (double)numericUpDown11.Value;
            GlobalData.AxisX.Speed = (double)numericUpDown9.Value;
            GlobalData.AxisX.LoadingPosition = (double)numericUpDown10.Value;

            // Axis Y
            GlobalData.AxisY.CurrentPosition = (double)numericUpDown1.Value;
            GlobalData.AxisY.Speed = (double)numericUpDown5.Value;
            GlobalData.AxisY.LoadingPosition = (double)numericUpDown12.Value;

            // Axis Z
            GlobalData.AxisZ.CurrentPosition = (double)numericUpDown19.Value;
            GlobalData.AxisZ.Speed = (double)numericUpDown23.Value;
            GlobalData.AxisZ.LoadingPosition = (double)numericUpDown24.Value;

            // Axis T
            GlobalData.AxisT.CurrentPosition = (double)numericUpDown13.Value;
            GlobalData.AxisT.Speed = (double)numericUpDown17.Value;
            GlobalData.AxisT.LoadingPosition = (double)numericUpDown18.Value;
        }
    }
}
