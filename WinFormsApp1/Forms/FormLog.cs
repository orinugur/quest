using System;
using System.Linq;
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
            // 로그 불러오기
            BindLogDatesToComboBox();

            // 선택된 날짜의 로그 로드
            LoadSelectedLog();
        }

        private void BindLogDatesToComboBox()
        {
            var dates = LogHelper.GetAvailableLogDates();
            
            if (dates.Count > 0)
            {
                // DateTime 목록을 "yyyy-MM-dd" 문자열 리스트로 변환하여 콤보박스에 할당
                comboBox1.DataSource = dates.Select(d => d.ToString("yyyy-MM-dd")).ToList();
                // 가장 최신 날짜
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("로그 없음");
                comboBox1.SelectedIndex = 0;
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            // 조회 버튼 클릭 시 선택된 콤보박스 값으로 재조회(새로고침)
            LoadSelectedLog();
        }

        private void LoadSelectedLog()
        {
            string? selectedValue = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedValue) || selectedValue == "로그 없음")
            {
                LoadLogForDate(DateTime.Today);
                return;
            }

            if (DateTime.TryParse(selectedValue, out DateTime selectedDate))
            {
                LoadLogForDate(selectedDate);
            }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedLog();
        }
    }
}