using L2.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace AppServer
{
    public partial class frmLogin : L3.BaseForm
    {
        public static bool LoginSucceeded = false;

        public frmLogin()
        {
            InitializeComponent();            

            this.Icon = AppServer.Properties.Resources.icons8_import_40;
            this._btnShow.Image = AppServer.Properties.Resources.view;
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            try
            {
                var teachers = App.Db.Table<Teacher>().Engine.Select(new List<L1.BaseField> { 
                    new L1.EqField("username", txtUsername.Text),
                    new L1.EqField("password", txtPassword.Text)
                });

                if (teachers.Count == 0)
                {
                    MessageBox.Show("Sai thông tin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                }
                else
                {
                    App.Teacher = teachers[0];
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sư muốn thoát?",
                "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
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
