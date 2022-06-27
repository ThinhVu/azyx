using AppServer.UIQuestionSheet.UIQuestion;
using L2.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AppServer.UIQuestionSheet
{
    public partial class QuestionSheetManageCard : L3.BaseUserControl
    {
        private List<QuestionSheet> _qsheets;
        //
        public QuestionSheetManageCard()
        {
            InitializeComponent();
        }
        //
        private void QuestionSheetManageCard_Load(object sender, EventArgs e)
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
        
        private void _btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == L3.AddEditBox<QuestionSheet, QuestionSheetCard>.Add(_addItem))
                    _loadData();
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        private void _btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var qSheet = _qsheets[_lvQSheet.SelectedIndices[0]];
                if (DialogResult.Yes == L3.AddEditBox<QuestionSheet, QuestionSheetCard>.Edit(qSheet, _editItem))
                    _loadData();
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        private void _btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show(
                    "Bạn chắc chắn muốn xóa đề thi này?", 
                    "Xóa đề thi", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    var qSheet = _qsheets[_lvQSheet.SelectedIndices[0]];
                    
                    // Step 1: delete question in current sheet
                    App.Db.Table<Question>().Engine.Delete(
                        where: new List<L1.BaseField> { new L1.EqField("QuestionSheetId", qSheet.Id) });

                    // Step 2: delete this sheet
                    App.Db.Table<QuestionSheet>().HardDelete(qSheet);

                    MessageBox.Show("Thành công", "Xóa đề thi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _loadData();
                }
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        private void _btnQuestionManage_Click(object sender, EventArgs e)
        {
            try
            {
                var qSheet = _qsheets[_lvQSheet.SelectedIndices[0]];
                new frmQuestionManager() { QuestionSheet = qSheet }.ShowDialog();
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        private void _lvQSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_qsheets == null)
                return;

            bool itemIsSelected = _lvQSheet.SelectedIndices.Count > 0;
            int itemIndex = itemIsSelected ? _lvQSheet.SelectedIndices[0] : -1;
            bool itemIsUsed = itemIsSelected && _qsheets.Count > itemIndex && _qsheets[itemIndex].Used;

            _btnQuestionManage.Visible = itemIsSelected;
            _btnEdit.Visible = _btnDelete.Visible = itemIsSelected && !itemIsUsed;
        }
        //
        private bool _addItem(QuestionSheet item)
        {
            if (item.SubjectId == 0)
                return false;
            // Step 0: Check if Alias already stored in db
            int qSheetWithCurrentAliasCount = App.Db.Table<QuestionSheet>().Engine.Count(
                new List<L1.BaseField>{ new L1.EqField("alias", item.Alias) });
            if (qSheetWithCurrentAliasCount > 0)
            {
                MessageBox.Show("Đã tồn tại đề thi với mã đề " + item.Alias, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Step 1: Insert question sheet
            int itemId = App.Db.Table<QuestionSheet>().Insert(item);
            var qSheet = App.Db.Table<QuestionSheet>().Get(itemId);
            // Step 2: Insert question
            frmQuestionManager fqm = new frmQuestionManager();
            fqm.QuestionSheet = qSheet;
            fqm.ShowDialog();
            return true;
        }
        private bool _editItem(QuestionSheet item)
        {
            if (item.SubjectId == 0)
                return false;

            App.Db.Table<QuestionSheet>().Update(item);

            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa thông tin câu hỏi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmQuestionManager fqm = new frmQuestionManager();
                fqm.QuestionSheet = item;
                fqm.ShowDialog();
            }

            return true;
        }
        private void _loadData()
        {
            _lvQSheet.Items.Clear();
            _qsheets = App.Db.Table<QuestionSheet>().Get();

            if (_qsheets.Count > 0)
            {                
                int i = 0;
                Subject subject;
                foreach (var model in _qsheets)
                {
                    i++;
                    var viewItem = _lvQSheet.Items.Add(i + "");
                    
                    viewItem.SubItems.Add(model.Alias);
                    subject = App.Db.Table<Subject>().Get(model.SubjectId);
                    if (subject != null)
                        viewItem.SubItems.Add(subject.Name);
                    else
                        viewItem.SubItems.Add(string.Empty);
                    viewItem.SubItems.Add(model.TestTime.ToString());
                    viewItem.SubItems.Add(model.AdditionInfo);

                    viewItem.BackColor = i % 2 == 0 ? Color.White : Color.LightGray;
                }
            }
            else
            {
                _btnEdit.Visible = _btnDelete.Visible = _btnQuestionManage.Visible = false;
            }
        }
    }
}
