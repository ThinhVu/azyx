using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppServer.UITheTest
{
    public partial class TheTestReport : UserControl, L3.IReportCard<L2.ViewModels.TheTestReportVM>
    {
        const int RECORD_PER_PAGE = 27;
        private L2.ViewModels.TheTestReportVM _model;
        public int TotalPages { get; set; }

        // -
        public TheTestReport()
        {
            InitializeComponent();           
        }
        // -
        public void SetModel(L2.ViewModels.TheTestReportVM model)
        {
            _model = model;            
            this.TotalPages = (int)(model.Answers.Count / RECORD_PER_PAGE)
                + (model.Answers.Count % RECORD_PER_PAGE != 0 ? 1 : 0);
        }

        private string _appendDot(string content)
        {
            return content + "....................................................................................................................................................";
        }

        /// <summary>
        /// Show page base 0
        /// </summary>
        /// <param name="pageIndex"></param>
        public void ShowPage(int pageIndex)
        {           
            _lblReportDate.Text = DateTime.Now.ToString("dd/MMMM/yyyy");
            _lblReportTime.Text = DateTime.Now.ToLongTimeString();

            var qSheet = App.Db.Table<L2.Models.QuestionSheet>().Get(_model.QuestionSheetId);

            // I. Test info
            _lblTestAlias.Text = _appendDot("Mã bài thi: " + _model.Alias);
            _lblTestTime.Text = _appendDot("Thời gian thi: " + qSheet.TestTime + " phút");
            _lblTestName.Text = _appendDot("Tên bài thi: " + _model.Name);
            _lblSubjectName.Text = _appendDot("Tên môn thi: " + _model.SubjectName);
            _lblTestDate.Text = _appendDot("Ngày thi: " + _model.CreatedDate.ToString("dd/MM/yyyy"));

            _lblPageIndex.Text = (pageIndex + 1).ToString();
            _lvAnswer.Items.Clear();

            if (_model.Answers == null || _model.Answers.Count == 0)
                return;

            // II. Student score            
            int lowerBound = pageIndex * RECORD_PER_PAGE;
            int upperBound = lowerBound + RECORD_PER_PAGE;

            _lvAnswer.Items.Clear();

            if (_model.Answers.Count > lowerBound)
            {
                if (_model.Answers.Count < upperBound)
                    upperBound = _model.Answers.Count;

                for (int i = lowerBound; i < upperBound; i++)
                {
                    var answer = _model.Answers[i];
                    var total = answer.Correct + answer.Incorrect + answer.NotDone;
                    var scorePerCorrect = Math.Round(10.0 / total, 2, MidpointRounding.AwayFromZero);
                    var viewItem = _lvAnswer.Items.Add(i.ToString());
                    viewItem.BackColor = i % 2 != 0 ? Color.White : Color.LightGray;
                    viewItem.SubItems.Add(answer.StudentName);
                    viewItem.SubItems.Add(answer.Correct * scorePerCorrect + "");
                    viewItem.SubItems.Add(answer.NotDone.ToString());
                    viewItem.SubItems.Add(answer.Correct.ToString());
                    viewItem.SubItems.Add(answer.Incorrect.ToString());
                    viewItem.SubItems.Add(answer.TimeSpent + "");
                }
            }
        }   
    }
}
