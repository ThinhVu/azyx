using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using L2.Models;

namespace ClientApp
{
    public partial class frmClient : L3.BaseForm
    {
        private List<TheTest> _theTests;
        private bool _quitApp = true;
        //
        public frmClient()
        {
            InitializeComponent();
            this.Icon = ClientApp.Properties.Resources.ico_graduation_cap;
            this.Text += " -- Thí sinh: " + Program.Student.Name;
        }
        //
        private void frmClient_Load(object sender, EventArgs e)
        {
            try
            {
                pnHost.Visible = true;
            _loadData();
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        private void frmClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (MessageBox.Show(
                "Bạn đang thực hiện đăng xuất tài khoản. " +
                "Khi đăng xuất khỏi tài khoản hiện tại, bạn sẽ trở về giao diện đăng nhập. " +
                "Bạn có muốn thực hiện thao tác này?",
                "Đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No);
        }
        //
        private void _btnJoin_Click(object sender, EventArgs e)
        {
            try
            {
                // check again if test is available
                var selectedTestId = _theTests[_lvTheTest.SelectedIndices[0]].Id;
                var theSelectedTest = Program.Database.Table<TheTest>().Get(selectedTestId);

                if (theSelectedTest.Status == 1)
                {
                    MessageBox.Show("Bài thi hiện tại đã kết thúc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // check if student done this test
                var studentAnswers = Program.Database.Table<TheTestResult>().Engine.Select(
                    new List<L1.BaseField>()
                {
                    new L1.EqField("StudentId", Program.Student.Id),
                    new L1.EqField("TheTestId", theSelectedTest.Id)
                });

                int theTestAnswerId = 0;

                if (studentAnswers.Count > 0)
                {
                    if (studentAnswers[0].Submitted)
                    {
                        // submitted
                        MessageBox.Show("Bạn đã làm bài thi này rồi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        // joined but not submit
                        theTestAnswerId = studentAnswers[0].Id;
                    }
                }
                else
                {
                    // never join before
                    theTestAnswerId = Program.Database.Table<TheTestResult>().Insert(new TheTestResult
                    {
                        StudentId = Program.Student.Id,
                        TheTestId = theSelectedTest.Id,
                        Submitted = false,
                        AnswerSheet = "",
                        Correct = 0,
                        Incorrect = 0,
                        NotDone = 0,
                        TimeSpent = 0
                    });
                }
                
                // do exam
                this.Hide();
                var doExam = new frmDoExam(theSelectedTest, theTestAnswerId);                
                doExam.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        private void _btnUpdateExam_Click(object sender, EventArgs e)
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
        private void _lvTheTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnJoin.Visible = _lvTheTest.SelectedIndices.Count > 0;
        }
        //
        private void _loadData()
        {
            _theTests = Program.Database.Table<TheTest>().Engine.Select(
                where: new List<L1.BaseField> { new L1.NEqField("Status", 1) });

            _lvTheTest.Items.Clear();

            if (_theTests.Count == 0)
                return;

            foreach (var theTest in _theTests)
            {
                var viewItem = _lvTheTest.Items.Add(theTest.Alias);
                viewItem.SubItems.Add(theTest.Name);
                viewItem.SubItems.Add(_getSubjectName(theTest.SubjectId));
                viewItem.SubItems.Add(_getQSheetName(theTest.QuestionSheetId));
                viewItem.SubItems.Add(theTest.CreatedDate.ToString());
                viewItem.SubItems.Add(_getTestStatus(theTest.Status));
                viewItem.SubItems.Add(theTest.AdditionInfo);
            }

            _lvTheTest.Focus();
            _lvTheTest.SelectedIndices.Add(0);
        }
        private string _getTestStatus(int status)
        {
            return status == 0 ? "Đang thi" : status == 1 ? "Kết thúc" : "<Thiếu thông tin>";
        }
        private string _getSubjectName(int subjectId)
        {
            var subject = Program.Database.Table<Subject>().Get(subjectId);
            if (subject == null)
                return "<Thiếu thông tin>";
            else
                return subject.Name;
        }
        private string _getQSheetName(int qSheetId)
        {
            var qSheets = Program.Database.Table<QuestionSheet>().Engine.SelectFields(
                new List<string> { "Alias" },
                new List<L1.BaseField> { new L1.EqField("id", qSheetId) });

            if (qSheets.Count == 0)
                return "";
            else
                return qSheets[0].Alias;
        }
    }
}
