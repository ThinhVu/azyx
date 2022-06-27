using L2.Models;
using System.Collections.Generic;
using System.Windows.Forms;
namespace ClientApp
{
    public partial class frmLogin : L3.BaseForm
    {
        public frmLogin()
        {
            InitializeComponent();
            this.Icon = ClientApp.Properties.Resources.ico_login;
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                var students = Program.Database.Table<Student>().Engine.Select(
                    new List<L1.BaseField> { 
                    new L1.EqField("username", username),
                    new L1.EqField("password", password),
                });

                if (students.Count == 1)
                {
                    Program.Student = students[0];
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không tồn tại hoặc không chính xác. Vui lòng kiểm tra lại", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                }
            }
            catch (System.Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sư muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void _btnShow_Click(object sender, System.EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';

        }
    }
}
