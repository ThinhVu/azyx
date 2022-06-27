namespace L3
{
    // https://stackoverflow.com/questions/32591157/richtextbox-selection-highlight/32618479#32618479
    using System;
    using System.ComponentModel;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    public class ExRichText : RichTextBox
    {
        [DllImport("kernel32.dll", EntryPoint = "LoadLibraryW",
            CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern IntPtr LoadLibraryW(string s_File);
        public static IntPtr LoadLibrary(string s_File)
        {
            var module = LoadLibraryW(s_File);
            if (module != IntPtr.Zero)
                return module;
            var error = Marshal.GetLastWin32Error();
            throw new Win32Exception(error);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                try
                {
                    L1.Logger.LogLevel1("ExRichText loading MsftEdit.dll");
                    LoadLibrary("MsftEdit.dll"); // Available since XP SP1
                    cp.ClassName = "RichEdit50W";
                }
                catch (Exception ex) { 
                    /* Windows XP without any Service Pack.*/
                    L1.Logger.LogLevel1("ExRichText loading MsftEdit.dll failed: " + ex.Message);
                }
                return cp;
            }
        }
    }
}
