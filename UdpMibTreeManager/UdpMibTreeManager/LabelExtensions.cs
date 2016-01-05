using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdpMibTreeManager
{
    public static class LabelExtensions
    {
        public static void ChangeText (this Label label, string text)
        {
            if (label.InvokeRequired)
            {
                label.Invoke((Action)(() => ChangeText(label,text)));
            }
            else
            {
                label.Text = text;
            }
        }
    }
}
