using L2.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AppServer.UIStudent
{
    public partial class StudentManageCard : L3.BaseUserControl
    {
        private List<Student> _students;

        public StudentManageCard()
        {
            InitializeComponent();
        }
        private void StudentManageCard_Load(object sender, EventArgs e)
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
                if (App.Trial)
                {
                    if (_students.Count > 30)
                    {
                        L1.Logger.LogLevel1("This is trial version. Please contact us to buy license version.");
                        Environment.Exit(0);
                    }
                }

                if (DialogResult.Yes == L3.AddEditBox<Student, StudentCard>.Add(_addItem))
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
                if (DialogResult.Yes == L3.AddEditBox<Student, StudentCard>.Edit(_students[_lv.SelectedIndices[0]], _editItem))
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
                    "Thao tác Xóa sẽ xóa toàn bộ thông tin liên quan đến thí sinh đang chọn. Bạn có muốn xóa không", 
                    "Xóa thông tin thí sinh",
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question))
                {
                    _deleteItem(_students[_lv.SelectedIndices[0]]);
                    _loadData();
                }
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        private void _btnExamReport_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedStudent = _students[_lv.SelectedIndices[0]];            
                frmStudentScoreReportOptions.ShowReportOptions(selectedStudent);            
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        private void _lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            _btnEdit.Visible = 
                _btnDelete.Visible = 
                _btnExamReport.Visible = _lv.SelectedIndices.Count > 0;
        }       
        //
        private bool _addItem(Student item)
        {
            if (!_validate(item))
                return false;

            if (0 != App.Db.Table<Student>().Engine.Count(
                where: new List<L1.BaseField>(1){ new L1.EqField("Username", item.Username)}))
            {
                MessageBox.Show(
                    "Tên đăng nhập đã tồn tại. Vui lòng thay đổi tên đăng nhập khác",
                    "Thêm thông tin thí sinh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (0 < App.Db.Table<Student>().Insert(item))
            {
                MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Thêm thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool _editItem(Student item)
        {
            if (!_validate(item))
                return false;

            if (App.Db.Table<Student>().Engine.Count(new List<L1.BaseField>(1)
            {
                new L1.NEqField("Id", item.Id),
                new L1.EqField("Username", item.Username)
            }) > 0)
            {
                MessageBox.Show(
                    "Tên đăng nhập đã tồn tại. Vui lòng thay đổi tên đăng nhập khác",
                    "Thêm thông tin thí sinh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (App.Db.Table<Student>().Update(item) > 0)
            {
                MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Sửa thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }            
        }
        private void _deleteItem(Student item)
        {
            // Hard delete student answer
            App.Db.Table<TheTestResult>().Engine.Delete(new List<L1.BaseField>
            {
                new L1.EqField("StudentId", item.Id)
            });

            // Hard delete StudentTbl
            if (App.Db.Table<Student>().HardDelete(item) == 1)
            {
                MessageBox.Show(
                       "Thành công.",
                       "Xóa thông tin thí sinh",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                       "Thất bại.", // because??
                       "Xóa thông tin thí sinh",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
            }
        }
        //
        private bool _validate(Student item)
        {
            if (item.Username.Length < 6)
            {
                MessageBox.Show(
                    "Tên đăng nhập phải có độ dài lớn hơn 6 ký tự",
                    "Thông tin thí sinh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return false;
            }

            if (item.Password.Length < 6)
            {
                MessageBox.Show(
                    "Mật khẩu phải có độ dài lớn hơn 6 ký tự",
                    "Thông tin thí sinh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return false;
            }

            if (string.IsNullOrWhiteSpace(item.Name))
            {
                MessageBox.Show(
                    "Tên thí sinh không được để trống",
                    "Thông tin thí sinh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return false;
            }

            if (item.ClassId == 0)
            {
                MessageBox.Show("Thiếu thông tin lớp",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void _loadData()
        {
            _lv.Items.Clear();
            _students = App.Db.Table<Student>().Get();
            if (_students.Count > 0)
            {
                int i = 0;
                foreach (var model in _students)
                {
                    i++;
                    var viewItem = _lv.Items.Add(i + "");
                    //
                    viewItem.SubItems.Add(model.Alias);
                    viewItem.SubItems.Add(model.Name);
                    viewItem.SubItems.Add(model.Email);
                    viewItem.SubItems.Add(model.PhoneNumber);
                    viewItem.SubItems.Add(_getClassName(model.ClassId));
                    viewItem.SubItems.Add(model.AdditionInfo);
                    viewItem.SubItems.Add(model.Username);
                    viewItem.SubItems.Add(model.Password);
                    //
                    viewItem.BackColor = i % 2 == 0 ? Color.White : Color.LightGray;
                }

                _lv.Focus();
                _lv.SelectedIndices.Add(0);
            }
            else
            {
                _btnEdit.Visible = _btnDelete.Visible = _btnExamReport.Visible = false;
            }
        }

        private string _getClassName(int classId)
        {
            var @class = App.Db.Table<Class>().Get(classId);
            if (@class != null)
                return @class.Name;
            else
                return "<Thiếu thông tin>";
        }
    }
}
