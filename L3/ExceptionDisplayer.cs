using System;
using System.Windows.Forms;

namespace L3
{
    public static class ExceptionDisplayer
    {
        public static void ShowOkError(Exception ex)
        {
            if (ex == null)
                return;
            try
            {
                L1.Logger.Log(ex);
                System.Windows.Forms.MessageBox.Show(ex.Message, "Lỗi", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            catch (Exception)
            {                
            }
        }
    }
}
