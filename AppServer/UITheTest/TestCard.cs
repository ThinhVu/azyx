using System;
using System.Collections.Generic;
using System.Windows.Forms;
using L2.Models;
using AppServer.UIQuestionSheet.UIQuestion;

namespace AppServer.UITheTest
{
    public partial class TestCard : UserControl, L3.IAddEditCard<TheTest>
    {
        private List<Subject> _subjects;
        private List<QuestionSheet> _qSheets;

        public TestCard()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return "bài thi"; }
        }

        public void PrepareEditModel(TheTest model)
        {
            bool loadSubjectSuccessfully = _loadSubject();
            if (!loadSubjectSuccessfully) return;

            // select current subject of item
            int subjectIndex = _subjects.FindIndex((subject) => subject.Id == model.SubjectId);
            if (subjectIndex == -1)
            {
                MessageBox.Show("Thông tin môn học của bài thi không trùng với bất cứ môn học nào hiện có. Vui lòng chọn lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                subjectIndex = 0;
            }
            else
            {
                _cbSubject.SelectedIndex = subjectIndex;
            }
        }

        public void PrepareAddModel()
        {
            bool loadSubjectSuccessfully = _loadSubject();
            if (!loadSubjectSuccessfully) return;
            // select default subject
            _cbSubject.SelectedIndex = 0;
        }

        public void SetModel(TheTest model)
        {
            _lblId.Text = model.Id.ToString();
            _txtAlias.Text = model.Alias;
            _txtName.Text = model.Name;
            _dtpCreatedDate.Value = model.CreatedDate;
            _lblStatus.Text = model.Status.ToString();
            _txtAdditionlInfo.Text = model.AdditionInfo;
        }
        
        public TheTest GetModel()
        {
            int subjectId = 0; // not exist
            if (_subjects.Count != 0 && _subjects.Count > _cbSubject.SelectedIndex)
            {                
                subjectId = _subjects[_cbSubject.SelectedIndex].Id;
            }
            else
            {                
                if (_subjects.Count == 0)
                {
                    L1.Logger.LogLevel3("No subject.");
                }
                else
                {
                    L1.Logger.LogLevel3("Selected subject index:" + _cbSubject.SelectedIndex);
                    L1.Logger.LogLevel3("Subject count:" + _subjects.Count);
                }
            }

            int qSheetId = 0; // not exist
            if (_qSheets.Count != 0 && _qSheets.Count > _cbQuesionSheet.SelectedIndex)
            {
                qSheetId = _qSheets[_cbQuesionSheet.SelectedIndex].Id;
            }

            return new TheTest
            {
                Id = int.Parse(_lblId.Text),
                SubjectId = subjectId,
                QuestionSheetId = qSheetId,
                Alias = _txtAlias.Text,
                Name = _txtName.Text,
                CreatedDate = _dtpCreatedDate.Value,
                AdditionInfo = _txtAdditionlInfo.Text,
                Status = int.Parse(_lblStatus.Text)
            };
        }

        private void _cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: Load Question sheet Alias rather than question sheet id
            _btnQuestionSheetPreview.Enabled = false;
            L1.Logger.LogLevel3("Change subject. Clear question sheet....");
            _cbQuesionSheet.Items.Clear();

            var selectedSubject = _subjects[_cbSubject.SelectedIndex];
            L1.Logger.LogLevel3("Loading question sheet...");
            // load question sheet
            _qSheets = App.Db.Table<QuestionSheet>().Engine.Select(new List<L1.BaseField>{
                new L1.EqField(
                    name: "SubjectId",
                    value: selectedSubject.Id)
            });

            if (_qSheets.Count == 0)
            {
                L1.Logger.LogLevel3("No question sheet");
                return;
            }

            for (int i = 0; i < _qSheets.Count; i++)
            {
                L1.Logger.LogLevel3("Loading questionsheet" + _qSheets[i].Id);
                _cbQuesionSheet.Items.Add(_qSheets[i].Alias);
            }

            _cbQuesionSheet.SelectedIndex = 0;
            _btnQuestionSheetPreview.Enabled = true;
        }

        private void _btnQuestionSheetPreview_Click(object sender, EventArgs e)
        {
            var qSheet = _qSheets[_cbQuesionSheet.SelectedIndex];
            new frmQuestionPreview(qSheet).ShowDialog();
        }

        private bool _loadSubject()
        {
            // load subject if any
            _subjects = App.Db.Table<Subject>().Get();
            _cbSubject.Items.Clear();
            if (_subjects.Count == 0)
            {
                MessageBox.Show("Không có thông tin môn học. Vui lòng tạo thông tin môn học trước khi tạo bài thi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            for (int i = 0; i < _subjects.Count; i++)
                _cbSubject.Items.Add(_subjects[i].Name);
            return true;
        }
    }
}