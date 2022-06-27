using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace L3
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            // background color
            this.BackColor = Color.SkyBlue;

            // tabpage
            var tabPages = GetAll(this, typeof(TabPage));
            foreach (TabPage tabPage in tabPages)
            {
                tabPage.BackColor = Color.SkyBlue;
            }

            // button
            var buttons = GetAll(this, typeof(Button));
            foreach (Button button in buttons)
            {
                button.FlatStyle = FlatStyle.Flat;
                button.UseVisualStyleBackColor = false;
                button.BackColor = Color.Moccasin;
                button.ForeColor = Color.Black;
                button.FlatAppearance.BorderColor = Color.Orange;
                button.FlatAppearance.MouseDownBackColor = Color.Orange;
                button.FlatAppearance.MouseOverBackColor = Color.Orange;
                button.Enter += (_, __) => button.BackColor = Color.Orange;
                button.Leave += (_, __) => button.BackColor = Color.Moccasin;
            }
        }
    }    
}
