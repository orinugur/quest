namespace QuestProject.Models
{
    /// <summary>
    /// 모터 축(Axis)의 데이터를 관리하는 모델 클래스입니다.
    /// </summary>
    public class AxisData
    {
        public string Name { get; set; } = string.Empty;
        public double TargetPosition { get; set; } = 0.0;
        public double CurrentPosition { get; set; } = 0.0;
        public double Speed { get; set; } = 100.0;
        public double Acceleration { get; set; } = 500.0;
        public double Deceleration { get; set; } = 500.0;
        
        // 상태값 (예: 원점 복귀 완료 여부, 알람 상태 등)
        public bool IsHomed { get; set; } = false;
        public bool IsAlarm { get; set; } = false;
    }
}
