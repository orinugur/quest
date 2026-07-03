using System;
using System.Windows.Forms;
using QuestProject.Common;

namespace QuestProject.Forms
{
    public partial class FormLog : Form
    {
        public FormLog()
        {
            InitializeComponent();
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
            // 폼 로드 시 오늘 날짜의 로그를 자동으로 조회합니다.
            LoadLogForDate(DateTime.Today);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            // 조회 버튼 클릭 시 선택한 날짜의 로그를 조회합니다.
            LoadLogForDate(dtpLogDate.Value);
        }

        private void LoadLogForDate(DateTime date)
        {
            string logContent = LogHelper.ReadLog(date);
            if (string.IsNullOrEmpty(logContent))
            {
                txtLogOutput.Text = $"[{date:yyyy-MM-dd}] 로그 파일이 존재하지 않거나 내용이 비어 있습니다.";
            }
            else
            {
                txtLogOutput.Text = logContent;
                
                // 텍스트 박스 스크롤을 맨 아래로 내립니다.
                txtLogOutput.SelectionStart = txtLogOutput.Text.Length;
                txtLogOutput.ScrollToCaret();
            }
        }
    }
}