using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading.Tasks;

using L2.Models;

namespace AppServer.UIQuestionSheet.UIQuestion
{
    public partial class frmQuestionManager : L3.BaseForm
    {
        private List<Question> _questions;
        //
        public QuestionSheet QuestionSheet { get; set; }
        //
        public frmQuestionManager()
        {
            InitializeComponent();
        }
        //
        private void frmQuestionManager_Load(object sender, EventArgs e)
        {
            // dont allow add or delete question in question sheet which has been used
            _btnAdd.Visible = _btnDelete.Visible = _btnImport.Visible = !QuestionSheet.Used;
            // always allow user to edit question data
            _btnEdit.Visible = true;
            _loadData();
        }
        //
        private void _btnAdd_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == L3.AddEditBox<Question, QuestionCard>.Add(_addItem))
            {
                MessageBox.Show("Thành công", "Thêm câu hỏi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _loadData();
            }
        }
        private void _btnEdit_Click(object sender, EventArgs e)
        {
            int questionId = _questions[navBar.Current - 1].Id;
            var quesion = App.Db.Table<Question>().Get(questionId);
            if (DialogResult.Yes == L3.AddEditBox<Question, QuestionCard>.Edit(quesion, _editItem))
            {
                MessageBox.Show("Thành công", "Sửa câu hỏi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                navBar.Refresh();
            }
        }
        private void _btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa câu hỏi này hay không?", "Xóa câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                var question = _questions[navBar.Current - 1];
                App.Db.Table<Question>().HardDelete(_questions[navBar.Current - 1]);
                _loadData();
            }
        }
        private void _btnImport_Click(object sender, EventArgs e)
        {
            if (new frmQuestionImport() { QSheetId = QuestionSheet.Id }.ShowDialog() == DialogResult.OK)
                _loadData();
        }
        //
        private bool _addItem(Question item)
        {
            // validate
            if (item.CorrectAnswer < 0 || item.CorrectAnswer > 3)
            {
                MessageBox.Show("Bạn chưa chọn đáp án chính xác cho câu hỏi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            App.Db.Table<Question>().Insert(item);
            return true;
        }
        private bool _editItem(Question item)
        {
            App.Db.Table<Question>().Update(item);
            return true;
        }        
        private void _loadData()
        {
            Task.Factory.StartNew(() =>
            {
                // get question id list for specified subject
                _questions = App.Db.Table<Question>().Engine.SelectFields(
                    fields: new List<string> { "id" },
                    where: new List<L1.BaseField> { new L1.EqField("QuestionSheetId", QuestionSheet.Id ) });
            }).ContinueWith(t =>
            {
                if (_questions.Count > 0)
                {
                    // base 1
                    // query database and set to model
                    navBar.ChangeIndex = _displayQuestion;
                    navBar.Minimum = 1;
                    navBar.Maximum = _questions.Count;
                    // display the first item
                    navBar.Current = 1;
                    questionCard.Visible = false;
                    _pnLoading.Visible = true;
                }
                else // khong co cau hoi
                {
                    _pnLoading.Visible = false;
                    navBar.ChangeIndex = null;
                    navBar.Minimum = 0;
                    navBar.Maximum = 0;
                    navBar.Current = 0;
                    questionCard.Visible = false;

                    _btnEdit.Visible = _btnDelete.Visible = false;
                }
            }, TaskScheduler.FromCurrentSynchronizationContext());        
        }
        private void _displayQuestion(int index)
        {
            questionCard.Visible = false;
            Task.Factory
                .StartNew(() =>
                {
                    return App.Db.Table<Question>().Get(_questions[index - 1].Id);
                })
                .ContinueWith(t =>
                {
                    questionCard.SetModel(t.Result);
                    questionCard.Visible = true;
                }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}