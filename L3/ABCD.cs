using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace L3
{
    public partial class ABCD : UserControl
    {
        //[Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        //[Description("Test text displayed in the textbox"), Category("Data")]
        public ABCD()
        {
            InitializeComponent();
        }

        public Action<int> OnCheckedChanged;

        public void SetValue(int value)
        {
            switch (value)
            {
                case 0:
                    rdA.Checked = true;
                    break;
                case 1:
                    rdB.Checked = true;
                    break;
                case 2:
                    rdC.Checked = true;
                    break;
                case 3:
                    rdD.Checked = true;
                    break;

                default:
                    rdA.Checked = false;
                    rdB.Checked = false;
                    rdC.Checked = false;
                    rdD.Checked = false;
                    break;
            }
        }
        public int GetValue()
        {
            return rdA.Checked ? 0 : rdB.Checked ? 1 : rdC.Checked ? 2 : rdD.Checked ? 3 : 0;
        }

        private void rdC_Clicked(object sender, EventArgs e)
        {
            if (OnCheckedChanged != null)
                OnCheckedChanged(2);
        }
        private void rdB_Clicked(object sender, EventArgs e)
        {
            if (OnCheckedChanged != null)
                OnCheckedChanged(1);
        }
        private void rdA_Clicked(object sender, EventArgs e)
        {
            if (OnCheckedChanged != null)
                OnCheckedChanged(0);
        }
        private void rdD_Clicked(object sender, EventArgs e)
        {
            if (OnCheckedChanged != null)
                OnCheckedChanged(3);
        }
    }
}
