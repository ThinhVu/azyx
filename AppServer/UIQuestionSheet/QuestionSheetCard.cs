using L2.Models;
using L2.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppServer.UIQuestionSheet
{
    public partial class QuestionSheetCard : UserControl, L3.IAddEditCard<QuestionSheet>
    {
        private List<Subject> _subjects;
        private int _id;
        //
        public string Title { get { return "đề bài"; } }
        //
        public QuestionSheetCard()
        {
            InitializeComponent();
        }     
        //
        public void SetModel(QuestionSheet model)
        {
            _id = model.Id;
            _txtAlias.Text = model.Alias;
            // subject
            for (int i = 0; i < _subjects.Count; i++)
            {
                if (model.SubjectId == _subjects[i].Id)
                {
                    _cbSubject.SelectedIndex = i;
                    break;
                }
            }
            _nudTestTime.Value = model.TestTime;
            _rtbAdditionlInfo.Text = model.AdditionInfo;
        }
        public QuestionSheet GetModel()
        {
            int subjectId = 0;
            if (_subjects.Count > 0 && _subjects.Count > _cbSubject.SelectedIndex)
                subjectId = _subjects[_cbSubject.SelectedIndex].Id;

            return new QuestionSheet
            {
                Id = _id,
                Alias = _txtAlias.Text,
                SubjectId = subjectId,
                TestTime = (int)_nudTestTime.Value,
                AdditionInfo = _rtbAdditionlInfo.Text,
                Used = false
            };
        }
        public void PrepareEditModel(QuestionSheet model)
        {
            _loadSubject();           
        }
        public void PrepareAddModel()
        {
            _loadSubject();
        }
        //
        private bool _loadSubject()
        {
            _cbSubject.Items.Clear();
            _subjects = App.Db.Table<Subject>().Get();

            if (_subjects.Count == 0)
                return false;

            for (int i = 0; i < _subjects.Count; i++)
                _cbSubject.Items.Add(_subjects[i].Name);

            if (_cbSubject.Items.Count > 0)
                _cbSubject.SelectedIndex = 0;

            return true;
        }
    }
}
