using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace L3
{
    public partial class BaseUserControl : UserControl
    {
        public BaseUserControl()
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

        private void BaseUserControl_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.SkyBlue;

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
