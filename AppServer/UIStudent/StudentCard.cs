using L2.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppServer.UIStudent
{
    public partial class StudentCard : UserControl, L3.IAddEditCard<Student>
    {
        private List<Class> _classes;
        private int _id;
        //
        public string Title
        {
            get { return "học sinh"; }
        }
        //
        public StudentCard()
        {
            InitializeComponent();                       
        }
        //
        public Student GetModel()
        {
            int classId = 0;
            if (_classes.Count > 0)
                classId = _classes[_cbClasses.SelectedIndex].Id;

            return new Student()
            {
                // 
                Id = _id,
                // 
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                //
                Alias = _txtAlias.Text,
                ClassId = classId,
                Name = txtName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhone.Text,                
                AdditionInfo = txtAdditionInfo.Text
            };
        }

        public void SetModel(Student model)
        {
            // 
            _id = model.Id;
            // user
            txtUsername.Text = model.Username;
            txtPassword.Text = model.Password;
            //
            _txtAlias.Text = model.Alias;
            txtName.Text = model.Name;
            txtEmail.Text = model.Email;
            txtPhone.Text = model.PhoneNumber;
            txtAdditionInfo.Text = model.AdditionInfo;
            // show current class
            for (int i = 0; i < _classes.Count; i++)
            {
                if (model.ClassId == _classes[i].Id)
                {
                    _cbClasses.SelectedIndex = i;
                    break;
                }
            }

            // not allow to edit user name
            txtUsername.Enabled = false;
        }

        public void PrepareEditModel(Student model)
        {
            var loadClassSucceeded = _loadClasses();
            if (!loadClassSucceeded) return;

            for (int i = 0; i < _classes.Count; i++)
            {
                if (_classes[i].Id == model.ClassId)
                {
                    _cbClasses.SelectedIndex = i;
                    break;
                }
            }
        }
        
        public void PrepareAddModel()
        {
            _loadClasses();           
        }

        private bool _loadClasses()
        {
            _classes = App.Db.Table<Class>().Get();

            if (_classes.Count == 0)
                return false;

            foreach (var @class in _classes)
                _cbClasses.Items.Add(@class.Name);
            _cbClasses.SelectedIndex = 0;
            return true;
        }
    }
}
