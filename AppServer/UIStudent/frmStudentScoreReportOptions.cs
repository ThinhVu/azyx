using L2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AppServer.UIStudent
{
    public partial class frmStudentScoreReportOptions : L3.BaseForm
    {
        public Student Student;
        private List<Subject> _subjects;

        private frmStudentScoreReportOptions()
        {
            InitializeComponent();
        }

        private void StudentScoreReportOptions_Load(object sender, EventArgs e)
        {
            // load subject
            _subjects = App.Db.Table<Subject>().Get();
            if (_subjects.Count == 0)
            {
                _btnViewReport.Enabled = false;
                return;
            }
            
            for (int i = 0; i < _subjects.Count; i++)
                _cbSubject.Items.Add(_subjects[i].Name);

            _cbSubject.SelectedIndex = 0;
        }

        private void _btnViewReport_Click(object sender, EventArgs e)
        {
            var subject = _subjects[_cbSubject.SelectedIndex];

            // build model
            var vm = new L2.ViewModels.StudentReportVM();
            vm.Id = Student.Id;
            vm.Alias = Student.Alias;
            vm.Name = Student.Name;
            vm.Subject = subject.Name;
            
            // class name
            vm.Class = App.Db.Table<Class>().Get(Student.ClassId).Name;

            // results
            var theTests = App.Db.Table<TheTest>().Engine.Select(
                where: new List<L1.BaseField> { new L1.EqField("SubjectId", subject.Id) });
           
            if (theTests.Count == 0)
            {
                MessageBox.Show("Không có thông tin bài thi liên quan đến môn học đang chọn", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            vm.TestResults = new List<L2.ViewModels.StudentReportVM.TheTestAnswerVM>();

            var theTestIds = new List<object>();
            foreach (var theTest in theTests)
                theTestIds.Add(theTest.Id);

            var theTestAnswers = App.Db.Table<TheTestResult>().Engine.SelectFields(
                fields: new List<string> { "TheTestId", "Correct", "Incorrect", "NotDone", "TimeSpent" },
                where: new List<L1.BaseField> { 
                                new L1.EqField("StudentId", Student.Id),
                                new L1.InField("TheTestId", theTestIds, SqlDbType.Int)
                            });

            if (theTestAnswers.Count == 0)
            {
                MessageBox.Show("Không có thông tin điểm cho môn thi hiện tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            for (int i = 0; i < theTestAnswers.Count; i++)
            {
                var answer = theTestAnswers[i];
                var theTest = _getTheTest(theTests, answer.TheTestId);
                var tavm = new L2.ViewModels.StudentReportVM.TheTestAnswerVM();
                tavm.Id = i + 1;
                tavm.TheTestId = theTest.Id;
                tavm.TestName = theTest.Name;
                tavm.TestDate = theTest.CreatedDate.ToString("dd/MM/yyyy");
                tavm.TotalScore = Math.Round(10.0 / (answer.Correct + answer.Incorrect + answer.NotDone) * answer.Correct, 2, MidpointRounding.AwayFromZero);
                tavm.NotDone = answer.NotDone;
                tavm.Correct = answer.Correct;
                tavm.Incorrect = answer.Incorrect;
                tavm.TimeSpent = answer.TimeSpent;
                //
                vm.TestResults.Add(tavm);
            }
          
            L3.frmPortraitReport<L2.ViewModels.StudentReportVM, StudentScoreReportCard>.ShowReport(vm);
            this.Close();
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private TheTest _getTheTest(List<TheTest> theTests, int theTestId)
        {
            foreach (var theTest in theTests)
            {
                if (theTest.Id == theTestId)
                    return theTest;
            }
            return new TheTest();
        }

        public static void ShowReportOptions(Student model)
        {
            var frmReportOption = new frmStudentScoreReportOptions();
            frmReportOption.Student = model;
            frmReportOption.ShowDialog();
        }
    }
}
