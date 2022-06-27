using System;
using System.Windows.Forms;

namespace L3
{    
    public partial class Navigation : UserControl
    {
        public int Current
        {
            get
            {
                return ((int)nudIndex.Value);
            }
            set
            {
                nudIndex.Value = value;
                if (ChangeIndex != null)
                    ChangeIndex(value);
                ChangeButtonState();
            }
        }        
        public int Minimum 
        {
            get
            {
                return (int)nudIndex.Minimum;
            }
            set
            {
                nudIndex.Minimum = value;
            }
        }
        public int Maximum
        {
            get
            {
                return (int)nudIndex.Maximum;
            }
            set
            {
                nudIndex.Maximum = value;
                _lblMaximum.Text = "/ " + value;
            } 
        }

        public Action<int> ChangeIndex;
  
        public Navigation()
        {
            InitializeComponent();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            Current--;           
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            // just funny, no it's not
            // it actually change state
            if (Current != Maximum || Current != Minimum)
                Current = Current;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Current++;
        }

        private void ChangeButtonState()
        {
            btnPrev.Enabled = true;
            btnNext.Enabled = true;

            int current = (int)nudIndex.Value;
            int max = (int)nudIndex.Maximum;
            int min = (int)nudIndex.Minimum;

            if (current == min)
            {
                btnPrev.Enabled = false;
            }

            if (current == max)
            {
                btnNext.Enabled = false;
            }
        }

        public void Refresh()
        {
            ChangeIndex(Current);
        }
    }
}
