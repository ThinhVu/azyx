using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AppServer
{
    public partial class frmServer : L3.BaseForm
    {
        // store latest button clicked by user
        private Button _latestClicked;
        //-
        public frmServer()
        {
            InitializeComponent();
            this.Icon = AppServer.Properties.Resources.icons8_literature_40;
        }
        //-
        private void _btnManageClass_Click(object sender, EventArgs e)
        {
            try
            {
                _setClearSelected(_btnManageClass);
                _showCard(new AppServer.UIClass.ClassManageCard());
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        private void btnManageSubject_Click(object sender, EventArgs e)
        {
            try
            {
                _setClearSelected(_btnManageSubject);
                _showCard(new AppServer.UISubject.SubjectManageCard());
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        private void btnManageStudent_Click(object sender, EventArgs e)
        {
            try
            {
                _setClearSelected(_btnManageStudent);            
                _showCard(new AppServer.UIStudent.StudentManageCard());
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        private void btnManageQuestionSheet_Click(object sender, EventArgs e)
        {
            try
            {
                _setClearSelected(_btnManageQuestionSheet);
                _showCard(new AppServer.UIQuestionSheet.QuestionSheetManageCard());
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }        
        //-
        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedIndex == 1)
            {
                if (_latestClicked == null)
                    // show class as a default page
                    _latestClicked = _btnManageClass;
                _latestClicked.PerformClick();
            }
        }
        private void _mnuItemReportBug_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("mailto:vutrongthinhk7@gmail.com&subject=Bug%20report&body=");
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        //-
        private void _showCard(Control card)
        {
            pnManageHost.Controls.Clear();
            pnManageHost.Controls.Add(card);
            card.Dock = DockStyle.Fill;
        }
        private void _setClearSelected(Button selectedButton)
        {
            _latestClicked = selectedButton;
            if (_latestClicked == null)
                _latestClicked = _btnManageClass;
        }        
    }
}
