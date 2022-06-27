using L1;
using L2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AppServer.UITheTest
{
    public partial class TestManageCard : L3.BaseUserControl
    {
        // _theTests contain all test info, over the time, this will contain alot of record so  we need paging
        private List<TheTest> _theTests;
        // _selectedTestId store selected test position
        private int _selectedTestId;
        //
        public TestManageCard()
        {
            InitializeComponent();

            _theTests = new List<TheTest>();
        }
        //
        private void TestManageCard_Load(object sender, EventArgs e)
        {
            try
            {
                _loadData();
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        private void _btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == L3.AddEditBox<TheTest, TestCard>.Add(_addItem))
                    _loadData();
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        private void _btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                // update status of current
                var selectedTest = _theTests[_lvaTheTest.SelectedIndices[0]];
                // update status
                App.Db.Table<TheTest>().Engine.Update(
                    new List<BaseField> { new EqField("Status", 1) },
                    new List<BaseField> { new EqField("Id", selectedTest.Id) });

                _loadData();
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        //
        private void _btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                _loadData();
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        private void _btnViewTestResult_Click(object sender, EventArgs e)
        {
            try
            {
                // get current test info
                var theTest = App.Db.Table<TheTest>().Get(_selectedTestId);

                // get test detail info
                var vm = new L2.ViewModels.TheTestReportVM();
                vm.Id = theTest.Id;
                vm.Alias = theTest.Alias;
                vm.QuestionSheetId = theTest.QuestionSheetId;
                vm.SubjectId = theTest.SubjectId;
                vm.Name = theTest.Name;
                vm.CreatedDate = theTest.CreatedDate;
                vm.AdditionInfo = theTest.AdditionInfo;
                vm.SubjectName =
                    App.Db.Table<Subject>().Engine.SelectFields(
                        new List<string> { "name" },
                        new List<BaseField> { new L1.EqField("id", theTest.SubjectId) }
                    )[0].Name;

                // get answers
                vm.Answers = new List<L2.ViewModels.TheTestReportVM.TheTestAnswerVM>();

                var theTestAnswers =
                    App.Db.Table<TheTestResult>().Engine.Select(
                        new List<BaseField> { new L1.EqField("TheTestId", theTest.Id) });

                foreach (var answer in theTestAnswers)
                {
                    var answerVM = new L2.ViewModels.TheTestReportVM.TheTestAnswerVM();
                    answerVM.Id = answer.Id;
                    answerVM.Correct = answer.Correct;
                    answerVM.Incorrect = answer.Incorrect;
                    answerVM.NotDone = answer.NotDone;
                    answerVM.TimeSpent = answer.TimeSpent;
                    //
                    answerVM.StudentId = answer.StudentId;
                    answerVM.StudentName =
                        App.Db.Table<Student>().Engine.SelectFields(
                            new List<string> { "name" },
                            new List<BaseField> { new L1.EqField("id", answer.StudentId) }
                        )[0].Name;
                    //
                    vm.Answers.Add(answerVM);
                }

                L3.frmPortraitReport<L2.ViewModels.TheTestReportVM, TheTestReport>.ShowReport(vm);
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        private void _chkHideTheTestDone_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                _selectedTestId = 0;
                _loadData();
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        private void _lvTheTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool noItemSelected = _lvaTheTest.SelectedIndices.Count == 0;

            if (noItemSelected)
            {
                _btnStop.Visible = _btnViewTestResult.Visible = false;
                return;
            }

            // ok now go to detail for each button
            var selectedTest = _theTests[_lvaTheTest.SelectedIndices[0]];

            // store selected information
            _selectedTestId = selectedTest.Id;

            // user can stop the test if it has been started
            _btnStop.Visible = selectedTest.Status == 0;

            // user can view test result for the tests which are finished
            _btnViewTestResult.Visible = selectedTest.Status == 1;
        }
        //--
        private bool _addItem(TheTest item)
        {
            if (!_validateTheTestItem(item))
                return false;

            // insert and get inserted test
            int testId = App.Db.Table<TheTest>().Insert(item);
            var insertedTest = App.Db.Table<TheTest>().Get(testId);

            // set used state for question sheet
            App.Db.Table<QuestionSheet>().Engine.Update(
                fields: new List<L1.BaseField> { new L1.EqField("Used", 1) },
                where: new List<BaseField> { new L1.EqField("Id", insertedTest.QuestionSheetId) });

            return true;
        }
        private bool _validateTheTestItem(TheTest item)
        {
            if (item == null)
                return false;

            // check if subject is valid
            if (item.SubjectId < 1)
            {
                MessageBox.Show(
                    "Không thể tạo bài thi do chưa chọn môn thi.",
                    "Tạo bài thi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            // check if question sheet is valid
            if (item.QuestionSheetId < 1)
            {
                MessageBox.Show(
                    "Không thể tạo bài thi do chưa chọn đề thi.",
                    "Tạo bài thi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            // check if question sheet have at least 1 question
            int questionNumber = App.Db.Table<Question>().Engine.Count(
                where: new List<L1.BaseField> { new L1.EqField("QuestionSheetId", item.QuestionSheetId) });

            if (questionNumber == 0)
            {
                MessageBox.Show(
                    "Không thể tạo bài thi do đề thi không chứa câu hỏi",
                    "Tạo bài thi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        //--
        private void _loadData()
        {
            _lvaTheTest.Focus();
            _lvaTheTest.Items.Clear();

            var status = _chkHideTheTestDone.Checked ? 1 : -1;
            _theTests = App.Db.Table<TheTest>().Engine.Select(
                where: new List<BaseField> { new L1.NEqField("Status", status) });

            if (_theTests.Count > 0)
            {
                int selectedIndex = 0;
                for (int i = 0; i < _theTests.Count; i++)
                {
                    var theTest = _theTests[i];
                    //
                    if (theTest.Id == _selectedTestId)
                        selectedIndex = i;
                    //
                    var viewItem = _lvaTheTest.Items.Add((i + 1) + "");
                    viewItem.SubItems.Add(theTest.Alias);
                    viewItem.SubItems.Add(theTest.Name);
                    viewItem.SubItems.Add(_getSubjectName(theTest.SubjectId));
                    viewItem.SubItems.Add(_getQSheetAlias(theTest.QuestionSheetId));
                    viewItem.SubItems.Add(theTest.CreatedDate.ToString());
                    viewItem.SubItems.Add(_getTheTestStatus(theTest.Status, theTest.Id));
                    viewItem.SubItems.Add(theTest.AdditionInfo);
                    //
                    viewItem.BackColor = _getRowColor(i);
                }

                _lvaTheTest.Focus();
                _lvaTheTest.Items[selectedIndex].Selected = true;
            }
            else
            {
                _btnStop.Visible = _btnViewTestResult.Visible = false;
            }

            if (_lvaTheTest.Items.Count == 0)
            {
                MessageBox.Show("Hiện tại không có bất cứ thông tin bài thi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private Color _getRowColor(int rowIndex)
        {
            return rowIndex % 2 == 0 ? Color.LightGray : Color.White;
        }
        private string _getSubjectName(int subjectId)
        {
            var subject = App.Db.Table<Subject>().Get(subjectId);
            if (subject != null)
                return (subject.Name);
            else
                return ("<Thiếu thông tin>");
        }
        private string _getQSheetAlias(int qSheetId)
        {
            var qSheet = App.Db.Table<QuestionSheet>().Get(qSheetId);
            if (qSheet != null)
                return (qSheet.Alias);
            else
                return ("<Thiếu thông tin>");
        }
        private string _getTheTestStatus(int status, int theTestId)
        {
            if (status == 0)
            {
                // Dang thi
                var doingTestCount = App.Db.Table<L2.Models.TheTestResult>().Engine.Count(
                    new List<BaseField>
                                {
                                    new L1.EqField("TheTestId", theTestId),
                                    new L1.EqField("Submitted", false)
                                });
                return string.Format("Đang thi ({0})", doingTestCount);
            }
            else if (status == 1)
            {
                return "Kết thúc";
            }
            else
            {
                return "<Không xác định>";
            }
        }
    }
}
