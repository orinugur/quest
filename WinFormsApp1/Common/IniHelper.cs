using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuestProject.Common
{
    /// <summary>
    /// INI 형식의 설정을 파일에 저장하고 로드하기 위한 간단한 헬퍼 클래스입니다.
    /// </summary>
    public static class IniHelper
    {
        public static Dictionary<string, Dictionary<string, string>> Load(string filePath)
        {
            var data = new Dictionary<string, Dictionary<string, string>>(StringComparer.OrdinalIgnoreCase);
            if (!File.Exists(filePath))
                return data;

            string currentSection = "";
            foreach (var line in File.ReadLines(filePath, Encoding.UTF8))
            {
                var trimmed = line.Trim();
                if (string.IsNullOrEmpty(trimmed) || trimmed.StartsWith(";") || trimmed.StartsWith("#"))
                    continue;

                if (trimmed.StartsWith("[") && trimmed.EndsWith("]"))
                {
                    currentSection = trimmed.Substring(1, trimmed.Length - 2).Trim();
                    if (!data.ContainsKey(currentSection))
                    {
                        data[currentSection] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                    }
                }
                else
                {
                    int idx = trimmed.IndexOf('=');
                    if (idx > 0)
                    {
                        string key = trimmed.Substring(0, idx).Trim();
                        string val = trimmed.Substring(idx + 1).Trim();
                        if (!string.IsNullOrEmpty(currentSection))
                        {
                            if (!data.ContainsKey(currentSection))
                            {
                                data[currentSection] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                            }
                            data[currentSection][key] = val;
                        }
                    }
                }
            }
            return data;
        }

        public static void Save(string filePath, Dictionary<string, Dictionary<string, string>> data)
        {
            var sb = new StringBuilder();
            foreach (var section in data)
            {
                sb.AppendLine($"[{section.Key}]");
                foreach (var kvp in section.Value)
                {
                    sb.AppendLine($"{kvp.Key}={kvp.Value}");
                }
                sb.AppendLine();
            }
            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
        }
    }
}
