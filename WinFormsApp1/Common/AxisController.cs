using System;
using System.IO;
using System.Windows.Forms;
using QuestProject.Common;

namespace QuestProject.Common
{
    /// <summary>
    /// 모터 축(Axis)들의 이동 및 설정을 중앙 제어하는 클래스입니다.
    /// </summary>
    public static class AxisController
    {
        private static System.Windows.Forms.Timer _updateTimer;
        private static DateTime _lastUpdateTime;

        static AxisController()
        {
            _updateTimer = new System.Windows.Forms.Timer();
            _updateTimer.Interval = 50; // 50ms 마다 갱신
            _updateTimer.Tick += UpdateTimer_Tick;
        }

        /// <summary>
        /// config.ini 파일에서 각 축의 설정을 읽어 GlobalData에 반영합니다.
        /// </summary>
        public static void LoadConfiguration(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                    return;

                var data = IniHelper.Load(filePath);

                // Axis X
                if (data.TryGetValue("Axis X", out var axisX))
                {
                    if (axisX.TryGetValue("MaxSpeed", out var valMaxSpeed) && double.TryParse(valMaxSpeed, out var dMaxSpeed)) 
                        GlobalData.AxisX.Speed = dMaxSpeed;
                    if (axisX.TryGetValue("LoadingPosition", out var valLoading) && double.TryParse(valLoading, out var dLoading)) 
                        GlobalData.AxisX.LoadingPosition = dLoading;
                    if (axisX.TryGetValue("LimitMin", out var valLimitMin) && double.TryParse(valLimitMin, out var dLimitMin))
                        GlobalData.AxisX.LimitMin = dLimitMin;
                    if (axisX.TryGetValue("LimitMax", out var valLimitMax) && double.TryParse(valLimitMax, out var dLimitMax))
                        GlobalData.AxisX.LimitMax = dLimitMax;
                }

                // Axis Y
                if (data.TryGetValue("Axis Y", out var axisY))
                {
                    if (axisY.TryGetValue("MaxSpeed", out var valMaxSpeed) && double.TryParse(valMaxSpeed, out var dMaxSpeed)) 
                        GlobalData.AxisY.Speed = dMaxSpeed;
                    if (axisY.TryGetValue("LoadingPosition", out var valLoading) && double.TryParse(valLoading, out var dLoading)) 
                        GlobalData.AxisY.LoadingPosition = dLoading;
                    if (axisY.TryGetValue("LimitMin", out var valLimitMin) && double.TryParse(valLimitMin, out var dLimitMin))
                        GlobalData.AxisY.LimitMin = dLimitMin;
                    if (axisY.TryGetValue("LimitMax", out var valLimitMax) && double.TryParse(valLimitMax, out var dLimitMax))
                        GlobalData.AxisY.LimitMax = dLimitMax;
                }

                // Axis Z
                if (data.TryGetValue("Axis Z", out var axisZ))
                {
                    if (axisZ.TryGetValue("MaxSpeed", out var valMaxSpeed) && double.TryParse(valMaxSpeed, out var dMaxSpeed)) 
                        GlobalData.AxisZ.Speed = dMaxSpeed;
                    if (axisZ.TryGetValue("LoadingPosition", out var valLoading) && double.TryParse(valLoading, out var dLoading)) 
                        GlobalData.AxisZ.LoadingPosition = dLoading;
                    if (axisZ.TryGetValue("LimitMin", out var valLimitMin) && double.TryParse(valLimitMin, out var dLimitMin))
                        GlobalData.AxisZ.LimitMin = dLimitMin;
                    if (axisZ.TryGetValue("LimitMax", out var valLimitMax) && double.TryParse(valLimitMax, out var dLimitMax))
                        GlobalData.AxisZ.LimitMax = dLimitMax;
                }

                // Axis T
                if (data.TryGetValue("Axis T", out var axisT))
                {
                    if (axisT.TryGetValue("MaxSpeed", out var valMaxSpeed) && double.TryParse(valMaxSpeed, out var dMaxSpeed)) 
                        GlobalData.AxisT.Speed = dMaxSpeed;
                    if (axisT.TryGetValue("LoadingPosition", out var valLoading) && double.TryParse(valLoading, out var dLoading)) 
                        GlobalData.AxisT.LoadingPosition = dLoading;
                    if (axisT.TryGetValue("LimitMin", out var valLimitMin) && double.TryParse(valLimitMin, out var dLimitMin))
                        GlobalData.AxisT.LimitMin = dLimitMin;
                    if (axisT.TryGetValue("LimitMax", out var valLimitMax) && double.TryParse(valLimitMax, out var dLimitMax))
                        GlobalData.AxisT.LimitMax = dLimitMax;
                }

                LogHelper.WriteLog("AxisController", "Configuration loaded and synchronized with GlobalData.");
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("AxisController", $"Error loading configuration: {ex.Message}");
            }
        }

        /// <summary>
        /// 특정 축을 지정된 목표 위치로 시간에 따라 이동시킵니다.
        /// </summary>
        public static void MoveTo(AxisData axis, double targetPosition)
        {
            axis.TargetPosition = targetPosition;
            LogHelper.WriteLog("AxisController", $"Starting move on {axis.Name} to {targetPosition} (Speed: {axis.Speed})");
            StartTimer();
        }

        /// <summary>
        /// 모든 축을 설정된 LoadingPosition으로 이동시킵니다.
        /// </summary>
        public static void MoveToLoadingPosition()
        {
            LogHelper.WriteLog("AxisController", "Initiating LoadingPosition movement for all axes.");
            foreach (var axis in GlobalData.AllAxes)
            {
                axis.TargetPosition = axis.LoadingPosition;
            }
            StartTimer();
        }

        /// <summary>
        /// 모든 축의 이동을 즉시 정지시킵니다.
        /// </summary>
        public static void Stop()
        {
            LogHelper.WriteLog("AxisController", "Stopping all axes immediately.");
            foreach (var axis in GlobalData.AllAxes)
            {
                axis.TargetPosition = axis.CurrentPosition;
            }
            _updateTimer.Stop();
        }

        /// <summary>
        /// 이동 시뮬레이션 타이머를 가동합니다.
        /// </summary>
        private static void StartTimer()
        {
            if (!_updateTimer.Enabled)
            {
                _lastUpdateTime = DateTime.Now;
                _updateTimer.Start();
            }
        }

        /// <summary>
        /// 실시간으로 각 축의 위치를 속도에 기반하여 업데이트합니다.
        /// </summary>
        private static void UpdateTimer_Tick(object? sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            double deltaTime = (now - _lastUpdateTime).TotalSeconds;
            _lastUpdateTime = now;

            // 아주 작은 델타 타임에 대한 방어 코드
            if (deltaTime <= 0)
                deltaTime = 0.001;

            bool anyMoving = false;

            foreach (var axis in GlobalData.AllAxes)
            {
                double diff = axis.TargetPosition - axis.CurrentPosition;
                if (Math.Abs(diff) > 0.001)
                {
                    anyMoving = true;
                    double direction = diff > 0 ? 1.0 : -1.0;
                    double step = axis.Speed * deltaTime;

                    // 만약 이동 거리가 남은 거리보다 크다면 목표 위치로 설정 완료
                    if (Math.Abs(diff) <= step)
                    {
                        axis.CurrentPosition = axis.TargetPosition;
                        LogHelper.WriteLog("AxisController", $"{axis.Name} reached target position: {axis.TargetPosition}");
                    }
                    else
                    {
                        axis.CurrentPosition += direction * step;
                    }
                }
            }

            // 모든 축이 정지했다면 타이머를 멈춤
            if (!anyMoving)
            {
                _updateTimer.Stop();
                LogHelper.WriteLog("AxisController", "All axes movement complete.");
            }
        }
    }
}
