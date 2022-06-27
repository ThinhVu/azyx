using L2.Models;
using System.Windows.Forms;

namespace AppServer.UISubject
{
    public partial class SubjectCard : UserControl, L3.IAddEditCard<Subject>
    {
        private int _id;

        public SubjectCard()
        {
            InitializeComponent();
        }

        public void SetModel(Subject model)
        {
            _id = model.Id;
            _txtAlias.Text = model.Alias;
            txtName.Text = model.Name;
            txtAdditionInfo.Text = model.AdditionInfo;
        }

        public Subject GetModel()
        {
            return new Subject
            {
                Id = _id,
                Alias = _txtAlias.Text,
                Name = txtName.Text,
                AdditionInfo = txtAdditionInfo.Text
            };
        }

        public string Title
        {
            get { return "môn học"; }
        }
       
        public void PrepareEditModel(Subject model)
        {
            // Don't need to implement cause no dependant data
        }
        public void PrepareAddModel()
        {
            // Don't need to implement cause no dependant data
        }
    }
}
