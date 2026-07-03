using System;
using System.Diagnostics;
using System.IO;

namespace QuestProject.Common
{
    public static class LogHelper
    {
        // 로그 저장 경로
        private static readonly string LogDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");

        // 전역 로깅 이벤트
        public static event Action<string, string>? OnLogRequested;

        // 시스템 시작 시 호출하여 초기화
        public static void Initialize()
        {
            if (!Directory.Exists(LogDir))
                Directory.CreateDirectory(LogDir);

            // 이벤트에 파일 쓰기 메서드 연결
            OnLogRequested += WriteLogToFile;
        }

        public static List<DateTime> GetAvailableLogDates()
        {
            var dates = new List<DateTime>();
            if (!Directory.Exists(LogDir)) return dates;

            // Logs 폴더 내의 모든 .log 파일을 읽어옵니다.
            foreach (var file in new DirectoryInfo(LogDir).GetFiles("*.log"))
            {
                string fileName = Path.GetFileNameWithoutExtension(file.Name); // 예: 2024-05-20
                if (DateTime.TryParseExact(fileName, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime date))
                {
                    dates.Add(date);
                }
            }

            // 최신 날짜가 위로 오도록 내림차순 정렬
            dates.Sort((a, b) => b.CompareTo(a));
            return dates;
        }
        public static void WriteLog(string category, string message)
        {
            OnLogRequested?.Invoke(category, message); 
        }
        private static void WriteLogToFile(string category, string message)
        {
            string filePath = Path.Combine(LogDir, $"{DateTime.Now:yyyy-MM-dd}.log");
            string logText = $"[{DateTime.Now:HH:mm:ss}] [{category}] {message}{Environment.NewLine}";
            
            try { File.AppendAllText(filePath, logText); }
            catch { /* IO 에러 발생 시 프로그램 종료 방지 */ }
        }

        // 로그 파일 읽기 메서드
        public static string ReadLog(DateTime date)
        {
            try
            {
                if (!Directory.Exists(LogDir)) return string.Empty;
                
                string filePath = Path.Combine(LogDir, $"{date:yyyy-MM-dd}.log");
                if (!File.Exists(filePath)) return string.Empty;
                
                // 로그를 실시간으로 쓰고 있을 수 있으므로 FileShare.ReadWrite로 락 충돌 방지
                using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (var sr = new StreamReader(fs, System.Text.Encoding.UTF8))
                {
                    return sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                return $"로그 읽기 중 오류 발생: {ex.Message}";
            }
        }

        // 오래된 로그 삭제 메서드 (Main에서 호출)
        public static void DeleteOldLogs(int monthsToKeep)
        {
            try
            {
                if (!Directory.Exists(LogDir)) return;
                
                DateTime threshold = DateTime.Now.AddMonths(-monthsToKeep);
                foreach (var file in new DirectoryInfo(LogDir).GetFiles("*.log"))
                {
                    if (file.LastWriteTime < threshold) file.Delete();
                }
            }
            catch { /* 권한 문제 등 무시 */ }
        }

    }
}