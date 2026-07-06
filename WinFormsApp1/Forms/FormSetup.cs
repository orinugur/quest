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
            // 콤보박스 아이템 구성 (0~12 개월 및 직접입력)
            comboBox1.Items.Clear();
            for (int i = 0; i <= 12; i++)
            {
                comboBox1.Items.Add($"{i} 개월");
            }
            comboBox1.Items.Add("직접입력");
            comboBox1.SelectedIndex = 3; // 기본값 3개월

            // 콤보박스 선택 변경 이벤트 직접 연결
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;

            string defaultPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.ini");
            if (File.Exists(defaultPath))
            {
                LoadSettings(defaultPath);
            }
        }

        // 콤보박스 선택에 따라 직접입력 텍스트 박스 표시 제어
        private void ComboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (comboBox1.SelectedItem?.ToString() == "직접입력")
            {
                txtCustomRetention.Visible = true;
                lblCustomUnit.Visible = true;
                txtCustomRetention.Focus();
            }
            else
            {
                txtCustomRetention.Visible = false;
                lblCustomUnit.Visible = false;
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
                saveFileDialog.FileName = "config.ini"; 

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = saveFileDialog.FileName;
                    SaveSettings(selectedFilePath);
                    MessageBox.Show("환경설정이 저장되었습니다.", "저장 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogHelper.WriteLog("SetUp", "Seting Saved");
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
                    LogHelper.WriteLog("SetUp", "Seting Loaded");
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
                    { "MaxSpeed", numericUpDown6.Value.ToString() },
                    { "LimitMin", numericUpDown7.Value.ToString() },
                    { "LimitMax", numericUpDown8.Value.ToString() },
                    { "LoadingPosition", numericUpDown10.Value.ToString() }
                };

                // Axis Y (groupBox1)
                data["Axis Y"] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                    { "MaxSpeed", numericUpDown1.Value.ToString() },
                    { "LimitMin", numericUpDown2.Value.ToString() },
                    { "LimitMax", numericUpDown3.Value.ToString() },
                    { "LoadingPosition", numericUpDown4.Value.ToString() }
                };

                // Axis Z (groupBox4)
                data["Axis Z"] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                    { "MaxSpeed", numericUpDown5.Value.ToString() },
                    { "LimitMin", numericUpDown9.Value.ToString() },
                    { "LimitMax", numericUpDown11.Value.ToString() },
                    { "LoadingPosition", numericUpDown12.Value.ToString() }
                };

                // Axis T (groupBox3)
                data["Axis T"] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                    { "MaxSpeed", numericUpDown13.Value.ToString() },
                    { "LimitMin", numericUpDown14.Value.ToString() },
                    { "LimitMax", numericUpDown15.Value.ToString() },
                    { "LoadingPosition", numericUpDown16.Value.ToString() }
                };

                // System (로그 삭제 주기)
                int retentionMonths = 0;
                if (comboBox1.SelectedItem?.ToString() == "직접입력")
                {
                    if (int.TryParse(txtCustomRetention.Text, out int customValue) && customValue >= 0)
                    {
                        retentionMonths = customValue;
                    }
                    else
                    {
                        MessageBox.Show("직접 입력한 삭제 주기가 올바르지 않습니다. 0 이상의 숫자를 입력해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    string? selectedStr = comboBox1.SelectedItem?.ToString();
                    if (!string.IsNullOrEmpty(selectedStr))
                    {
                        string numericPart = new string(selectedStr.Where(char.IsDigit).ToArray());
                        if (int.TryParse(numericPart, out int parsedVal))
                        {
                            retentionMonths = parsedVal;
                        }
                    }
                }

                data["System"] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                    { "LogRetentionMonths", retentionMonths.ToString() }
                };

                IniHelper.Save(filePath, data);
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
                    if (axisX.TryGetValue("MaxSpeed", out var valMaxSpeed) && decimal.TryParse(valMaxSpeed, out var dMaxSpeed)) numericUpDown6.Value = dMaxSpeed;
                    if (axisX.TryGetValue("LimitMin", out var valLimitMin) && decimal.TryParse(valLimitMin, out var dLimitMin)) numericUpDown7.Value = dLimitMin;
                    if (axisX.TryGetValue("LimitMax", out var valLimitMax) && decimal.TryParse(valLimitMax, out var dLimitMax)) numericUpDown8.Value = dLimitMax;
                    if (axisX.TryGetValue("LoadingPosition", out var valLoading) && decimal.TryParse(valLoading, out var dLoading)) numericUpDown10.Value = dLoading;
                }

                // Axis Y (groupBox1)
                if (data.TryGetValue("Axis Y", out var axisY))
                {
                    if (axisY.TryGetValue("MaxSpeed", out var valMaxSpeed) && decimal.TryParse(valMaxSpeed, out var dMaxSpeed)) numericUpDown1.Value = dMaxSpeed;
                    if (axisY.TryGetValue("LimitMin", out var valLimitMin) && decimal.TryParse(valLimitMin, out var dLimitMin)) numericUpDown2.Value = dLimitMin;
                    if (axisY.TryGetValue("LimitMax", out var valLimitMax) && decimal.TryParse(valLimitMax, out var dLimitMax)) numericUpDown3.Value = dLimitMax;
                    if (axisY.TryGetValue("LoadingPosition", out var valLoading) && decimal.TryParse(valLoading, out var dLoading)) numericUpDown4.Value = dLoading;
                }

                // Axis Z (groupBox4)
                if (data.TryGetValue("Axis Z", out var axisZ))
                {
                    if (axisZ.TryGetValue("MaxSpeed", out var valMaxSpeed) && decimal.TryParse(valMaxSpeed, out var dMaxSpeed)) numericUpDown5.Value = dMaxSpeed;
                    if (axisZ.TryGetValue("LimitMin", out var valLimitMin) && decimal.TryParse(valLimitMin, out var dLimitMin)) numericUpDown9.Value = dLimitMin;
                    if (axisZ.TryGetValue("LimitMax", out var valLimitMax) && decimal.TryParse(valLimitMax, out var dLimitMax)) numericUpDown11.Value = dLimitMax;
                    if (axisZ.TryGetValue("LoadingPosition", out var valLoading) && decimal.TryParse(valLoading, out var dLoading)) numericUpDown12.Value = dLoading;
                }

                // Axis T (groupBox3)
                if (data.TryGetValue("Axis T", out var axisT))
                {
                    if (axisT.TryGetValue("MaxSpeed", out var valMaxSpeed) && decimal.TryParse(valMaxSpeed, out var dMaxSpeed)) numericUpDown13.Value = dMaxSpeed;
                    if (axisT.TryGetValue("LimitMin", out var valLimitMin) && decimal.TryParse(valLimitMin, out var dLimitMin)) numericUpDown14.Value = dLimitMin;
                    if (axisT.TryGetValue("LimitMax", out var valLimitMax) && decimal.TryParse(valLimitMax, out var dLimitMax)) numericUpDown15.Value = dLimitMax;
                    if (axisT.TryGetValue("LoadingPosition", out var valLoading) && decimal.TryParse(valLoading, out var dLoading)) numericUpDown16.Value = dLoading;
                }

                // System (로그 삭제 주기)
                if (data.TryGetValue("System", out var systemSection))
                {
                    if (systemSection.TryGetValue("LogRetentionMonths", out var valLogRetention) && int.TryParse(valLogRetention, out int retentionMonths))
                    {
                        if (retentionMonths >= 0 && retentionMonths <= 12)
                        {
                            comboBox1.SelectedIndex = retentionMonths;
                            txtCustomRetention.Visible = false;
                            lblCustomUnit.Visible = false;
                        }
                        else
                        {
                            comboBox1.SelectedItem = "직접입력";
                            txtCustomRetention.Text = retentionMonths.ToString();
                            txtCustomRetention.Visible = true;
                            lblCustomUnit.Visible = true;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"설정을 로드하는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 전체 로그 삭제 버튼 클릭 이벤트
        private void btnDeleteAllLogs_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "저장된 모든 로그 파일을 삭제하시겠습니까?\n이 작업은 되돌릴 수 없습니다.", 
                "로그 일괄 삭제 확인", 
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                try
                {
                    LogHelper.DeleteAllLogs();
                    MessageBox.Show("모든 로그 파일이 삭제되었습니다.", "삭제 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogHelper.WriteLog("System", "All log files deleted manually.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"로그 삭제 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
