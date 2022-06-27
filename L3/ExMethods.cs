using System.Drawing;
using System.Windows.Forms;

namespace L3
{
    public static class ExMethods
    {
        public static void RemoveStyle(this ExRichText r)
        {
            r.Font = new Font("Arial", 10, FontStyle.Regular);
        }
    }
}
