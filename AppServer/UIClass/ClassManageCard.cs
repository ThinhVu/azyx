using System;
using System.Collections.Generic;
using System.Windows.Forms;
// --
using L1;
using L2.Models;
using System.Drawing;

namespace AppServer.UIClass
{
    public partial class ClassManageCard : L3.BaseUserControl
    {
        private List<Class> _classes;

        public ClassManageCard()
        {
            InitializeComponent();
        }
        // --
        private void ClassManageCard_Load(object sender, EventArgs e)
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
        // --
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == L3.AddEditBox<Class, ClassCard>.Add(_addItem))
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
                var item = _classes[_lvClass.SelectedIndices[0]];
                if (DialogResult.Yes == L3.AddEditBox<Class, ClassCard>.Edit(item, _editItem))
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
                if (DialogResult.Yes == MessageBox.Show("Bạn muốn xóa thông tin lớp đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    App.Db.Table<Class>().HardDelete(_classes[_lvClass.SelectedIndices[0]]);
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _loadData();
                }
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        private void _lvClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (_lvClass.SelectedIndices.Count > 0)
                {
                    btnEdit.Visible = true;
                    int sltClassId = _classes[_lvClass.SelectedIndices[0]].Id;
                    int stuInSltClass = App.Db.Table<Student>().Engine.Count(
                        where: new List<BaseField> { new L1.EqField("ClassId", sltClassId) });
                    btnDelete.Visible = 0 == stuInSltClass;
                }
                else
                {
                    btnEdit.Visible = btnDelete.Visible = false;
                }
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        // --
        private bool _addItem(Class item)
        {
            App.Db.Table<Class>().Insert(item);
            MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
        private bool _editItem(Class item)
        {
            App.Db.Table<Class>().Update(item);
            MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
        private void _loadData()
        {
            _lvClass.Items.Clear();

            _classes = App.Db.Table<Class>().Get();
            if (_classes.Count > 0)
            {
                int i = 0;
                foreach (var @class in _classes)
                {
                    i++;
                    var item = _lvClass.Items.Add(i.ToString());
                    item.SubItems.Add(@class.Alias.ToString());
                    item.SubItems.Add(@class.Name);
                    item.SubItems.Add(@class.AdditionInfo);
                    // 
                    item.BackColor = i % 2 == 0 ? Color.White : Color.LightGray;
                }

                _lvClass.Focus();
                _lvClass.SelectedIndices.Add(0);
            }
            else
            {
                btnEdit.Visible = btnDelete.Visible = false;
            }
        }
    }
}
