using System.Collections.Generic;

namespace QuestProject.Common
{
    /// <summary>
    /// 프로그램 전체에서 공유되는 전역 데이터를 관리하는 클래스입니다.
    /// </summary>
    public static class GlobalData
    {
        // 개별 축 데이터 (X, Y, Z 등)
        public static AxisData AxisX = new AxisData { Name = "_axisX" };
        public static AxisData AxisY = new AxisData { Name = "_axisY" };
        public static AxisData AxisZ = new AxisData { Name = "_axisZ" };
        public static AxisData AxisT = new AxisData { Name = "_axisT" };
        public static List<AxisData> AllAxes = new List<AxisData> { AxisX, AxisY, AxisZ, AxisT };

        // 시스템 상태
        public static bool IsRunning = false;
        public static bool IsEmergency = false;
    }
}
