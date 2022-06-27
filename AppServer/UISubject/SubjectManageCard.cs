using L3;
using L2.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AppServer.UISubject
{
    public partial class SubjectManageCard : L3.BaseUserControl
    {
        private List<Subject> _subjects;
        //
        public SubjectManageCard()
        {
            InitializeComponent();
        }
        //
        private void SubjectManageCard_Load(object sender, EventArgs e)
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
        //
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == AddEditBox<Subject, SubjectCard>.Add(_addItem))
                    _loadData();
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == AddEditBox<Subject, SubjectCard>.Edit(_subjects[lvSubject.SelectedIndices[0]], _editItem))
                    _loadData();
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show(
                    "Thao tác Xóa sẽ xóa môn học ra khỏi danh sách môn học. Bạn thực sự muốn xóa?",
                    "Xóa thông tin môn học", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    _deleteItem(_subjects[lvSubject.SelectedIndices[0]]);
                    _loadData();
                }
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        private void lvSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Visible = 
                btnDelete.Visible = lvSubject.SelectedIndices.Count > 0;
        }
        //
        private bool _addItem(Subject item)
        {
            if (App.Db.Table<Subject>().Insert(item) > 0)
            {
                MessageBox.Show("Thêm thành công.", "Thêm thông tin môn học", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Thêm thất bại.", "Thêm thông tin môn học", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return true;
        }
        private bool _editItem(Subject item)
        {
            if (App.Db.Table<Subject>().Update(item) > 0)
            {
                MessageBox.Show("Sửa thành công.", "Sửa thông tin môn học", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Sửa thất bại.", "Sửa thông tin môn học", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return true;
        }
        private void _deleteItem(Subject item)
        {
            int subjectInQuestionSheet = App.Db.Table<QuestionSheet>().Engine.Count(new List<L1.BaseField>(1)
            {
                new L1.EqField("SubjectId", item.Id)
            });
            int subjectInTest = App.Db.Table<TheTest>().Engine.Count(new List<L1.BaseField>(1)
            {
                new L1.EqField("SubjectId", item.Id)
            });
            if (subjectInQuestionSheet + subjectInTest == 0)
            {
                if (App.Db.Table<Subject>().HardDelete(item) == 1)
                {
                    MessageBox.Show(
                        "Thành công.",
                        "Xóa thông tin môn học",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(
                    "Thông tin môn học đang được sử dụng. Không thể xóa",
                    "Xóa thông tin môn học",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void _loadData()
        {
            lvSubject.Items.Clear();
            
            //
            _subjects = App.Db.Table<Subject>().Get();
            if (_subjects.Count > 0)
            {
                int i = 0;
                foreach (var model in _subjects)
                {
                    i++;
                    var viewItem = lvSubject.Items.Add(i + "");
                    viewItem.BackColor = i % 2 == 0 ? Color.White : Color.LightGray;
                    viewItem.SubItems.Add(model.Alias);
                    viewItem.SubItems.Add(model.Name);
                    viewItem.SubItems.Add(model.AdditionInfo);
                }

                lvSubject.Focus();
                lvSubject.Items[0].Selected = true;
            }
            else
            {
                btnEdit.Visible = btnDelete.Visible = false;
            }
        }
    }
}
