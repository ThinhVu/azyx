using System.Windows.Forms;

namespace AppServer.UIClass
{
    public partial class ClassCard : UserControl, L3.IAddEditCard<L2.Models.Class>
    {
        private int _id;

        public ClassCard()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return "lớp học"; }
        }

        public void PrepareEditModel(L2.Models.Class model)
        {
            
        }

        public void PrepareAddModel()
        {
            
        }

        public void SetModel(L2.Models.Class model)
        {
            _id = model.Id;
            _txtClassAlias.Text = model.Alias;
            _txtClassName.Text = model.Name;
            _txtAdditionInfo.Text = model.AdditionInfo;
        }

        public L2.Models.Class GetModel()
        {
            return new L2.Models.Class
            {
                Id = _id,
                Alias = _txtClassAlias.Text,
                Name = _txtClassName.Text,
                AdditionInfo = _txtAdditionInfo.Text
            };
        }
    }
}
