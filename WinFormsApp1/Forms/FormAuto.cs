using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using QuestProject.Common;

namespace QuestProject.Forms
{
    public partial class FormAuto : Form
    {
        private int currentStep = 1;
        private bool isMovingToHome = false;
        private Dictionary<int, Dictionary<string, double>> recipeSteps = new Dictionary<int, Dictionary<string, double>>();

        public FormAuto()
        {
            InitializeComponent();
        }

        private void UiTimer_Tick(object? sender, EventArgs e)
        {
            textBox1.Text = GlobalData.AxisX.CurrentPosition.ToString("F2");
            textBox2.Text = GlobalData.AxisY.CurrentPosition.ToString("F2");
            textBox3.Text = GlobalData.AxisZ.CurrentPosition.ToString("F2");
            textBox4.Text = GlobalData.AxisT.CurrentPosition.ToString("F2");

            if (GlobalData.IsRunning)
            {
                label9.Text = isMovingToHome ? "Auto (Homing...)" : $"Auto (Step {currentStep}/5)";

                // 모든 축이 목표 위치에 도달했는지 확인
                bool allReached = true;
                foreach (var axis in GlobalData.AllAxes)
                {
                    if (Math.Abs(axis.CurrentPosition - axis.TargetPosition) > 0.001)
                    {
                        allReached = false;
                        break;
                    }
                }

                if (allReached)
                {
                    if (!isMovingToHome)
                    {
                        LogHelper.WriteLog("Auto", $"Step {currentStep} complete.");
                        currentStep++;
                        if (currentStep > 5)
                        {
                            // 모든 스텝 완료 시 Loading Position (원점) 복귀 시작
                            isMovingToHome = true;
                            AxisController.MoveToLoadingPosition();
                            LogHelper.WriteLog("Auto", "All steps completed. Returning all axes to loading positions (Home).");
                        }
                        else
                        {
                            // 다음 스텝으로 이동
                            if (recipeSteps.TryGetValue(currentStep, out var nextStep))
                            {
                                AxisController.MoveTo(GlobalData.AxisX, nextStep["X"]);
                                AxisController.MoveTo(GlobalData.AxisY, nextStep["Y"]);
                                AxisController.MoveTo(GlobalData.AxisZ, nextStep["Z"]);
                                AxisController.MoveTo(GlobalData.AxisT, nextStep["T"]);
                                LogHelper.WriteLog("Auto", $"Moving to Step {currentStep}. Targets - X: {nextStep["X"]:F2}, Y: {nextStep["Y"]:F2}, Z: {nextStep["Z"]:F2}, T: {nextStep["T"]:F2}");
                            }
                        }
                    }
                    else
                    {
                        // 원점 복귀 완료 후 Step 1부터 다시 진행
                        isMovingToHome = false;
                        currentStep = 1;
                        if (recipeSteps.TryGetValue(1, out var step1))
                        {
                            AxisController.MoveTo(GlobalData.AxisX, step1["X"]);
                            AxisController.MoveTo(GlobalData.AxisY, step1["Y"]);
                            AxisController.MoveTo(GlobalData.AxisZ, step1["Z"]);
                            AxisController.MoveTo(GlobalData.AxisT, step1["T"]);
                            LogHelper.WriteLog("Auto", $"Homing complete. Restarting sequence from Step 1. Targets - X: {step1["X"]:F2}, Y: {step1["Y"]:F2}, Z: {step1["Z"]:F2}, T: {step1["T"]:F2}");
                        }
                    }
                }
            }
            else
            {
                label9.Text = "Auto";
            }
        }

        private void btnAutoRun_Click(object sender, EventArgs e)
        {
            string recipePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Recipe.ini");
            if (!File.Exists(recipePath))
            {
                var defaultRecipe = new Dictionary<string, Dictionary<string, string>>(StringComparer.OrdinalIgnoreCase);
                for (int i = 1; i <= 5; i++)
                {
                    defaultRecipe[$"Step {i}"] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                    {
                        { "X", (i * 10.0).ToString("F1") },
                        { "Y", (i * 10.0).ToString("F1") },
                        { "Z", (i * 10.0).ToString("F1") },
                        { "T", (i * 10.0).ToString("F1") }
                    };
                }
                IniHelper.Save(recipePath, defaultRecipe);
                LogHelper.WriteLog("Auto", "Default Step-based Recipe.ini created.");
            }

            var data = IniHelper.Load(recipePath);
            recipeSteps.Clear();

            for (int i = 1; i <= 5; i++)
            {
                var stepData = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase)
                {
                    { "X", 0 }, { "Y", 0 }, { "Z", 0 }, { "T", 0 }
                };

                Dictionary<string, string>? section = null;
                if (data.TryGetValue($"Step {i}", out var s1)) section = s1;
                else if (data.TryGetValue($"Step{i}", out var s2)) section = s2;

                if (section != null)
                {
                    if (section.TryGetValue("X", out var valX) && double.TryParse(valX, out double x)) stepData["X"] = x;
                    if (section.TryGetValue("Y", out var valY) && double.TryParse(valY, out double y)) stepData["Y"] = y;
                    if (section.TryGetValue("Z", out var valZ) && double.TryParse(valZ, out double z)) stepData["Z"] = z;
                    if (section.TryGetValue("T", out var valT) && double.TryParse(valT, out double t)) stepData["T"] = t;
                }
                recipeSteps[i] = stepData;
            }

            currentStep = 1;
            isMovingToHome = false;

            if (recipeSteps.TryGetValue(1, out var step1))
            {
                AxisController.MoveTo(GlobalData.AxisX, step1["X"]);
                AxisController.MoveTo(GlobalData.AxisY, step1["Y"]);
                AxisController.MoveTo(GlobalData.AxisZ, step1["Z"]);
                AxisController.MoveTo(GlobalData.AxisT, step1["T"]);

                GlobalData.IsRunning = true;
                LogHelper.WriteLog("Auto", $"Auto Run started. Step 1 targets - X: {step1["X"]:F2}, Y: {step1["Y"]:F2}, Z: {step1["Z"]:F2}, T: {step1["T"]:F2}");
            }
        }

        private void btnAutoStop_Click(object sender, EventArgs e)
        {
            AxisController.Stop();
            GlobalData.IsRunning = false;
            LogHelper.WriteLog("Auto", "Auto Stop clicked. All axes stopped.");
        }

        private void btnResetHome_Click(object sender, EventArgs e)
        {
            GlobalData.IsRunning = false;
            AxisController.MoveToLoadingPosition();
            LogHelper.WriteLog("Auto", "Reset Home clicked. Stopping Auto Run and returning all axes to loading positions.");
        }
    }
}

