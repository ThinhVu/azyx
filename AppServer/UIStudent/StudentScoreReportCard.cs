using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppServer.UIStudent
{
    public partial class StudentScoreReportCard : UserControl, L3.IReportCard<L2.ViewModels.StudentReportVM>
    {        
        const int SCORE_PER_PAGE = 30;
        // -        
        public int TotalPages { get; set; }
        // -
        private L2.ViewModels.StudentReportVM _vm;
        // -
        public StudentScoreReportCard()
        {
            InitializeComponent();            
        }
        private string _appendDot(string content)
        {
            return content + "....................................................................................................................................................";
        }
        // --
        public void SetModel(L2.ViewModels.StudentReportVM viewModel)
        {
            _vm = viewModel;
            this.TotalPages = (int)(_vm.TestResults.Count / SCORE_PER_PAGE)
                + (_vm.TestResults.Count % SCORE_PER_PAGE != 0 ? 1 : 0);
        }
        public void ShowPage(int pageIndex)
        {            
            // I. infomation            
            _lblReportDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            _lblReportTime.Text = DateTime.Now.ToLongTimeString();

            //
            _lblStudentId.Text = _appendDot("Mã học sinh: " + _vm.Alias);
            _lblStudentName.Text = _appendDot("Tên học sinh: " + _vm.Name);
            _lblClassName.Text = _appendDot("Tên lớp học: " + _vm.Class);

            // II.
            _lblSubject.Text = _vm.Subject;

            _lblPageIndex.Text = (pageIndex + 1).ToString();
            _lvTestAnswer.Items.Clear();

            if (_vm.TestResults == null || _vm.TestResults.Count == 0)
                return;

            // select test related to selected subject            
            int lowerBound = pageIndex * SCORE_PER_PAGE;
            int upperBound = lowerBound + SCORE_PER_PAGE;

            if (lowerBound < _vm.TestResults.Count)
            {
                if (upperBound > _vm.TestResults.Count)
                    upperBound = _vm.TestResults.Count;

                for (int i = lowerBound; i < upperBound; i++)
                {
                    var rs = _vm.TestResults[i];
                    var vi = _lvTestAnswer.Items.Add(rs.Id.ToString());
                    vi.BackColor = i % 2 != 0 ? Color.White : Color.LightGray;
                    vi.SubItems.Add(rs.TheTestId.ToString());
                    vi.SubItems.Add(rs.TestName);
                    vi.SubItems.Add(rs.TestDate);
                    vi.SubItems.Add(rs.TotalScore.ToString());
                    vi.SubItems.Add(rs.NotDone.ToString());
                    vi.SubItems.Add(rs.Correct.ToString());
                    vi.SubItems.Add(rs.Incorrect.ToString());
                    vi.SubItems.Add(rs.TimeSpent.ToString());
                }
            }            
        }

        private void _lvTestAnswer_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Gray, e.Bounds);
            e.DrawText();
        }

        private void _lvTestAnswer_DrawItem(object sender, DrawListViewItemEventArgs e)
        {

        }
    }
}