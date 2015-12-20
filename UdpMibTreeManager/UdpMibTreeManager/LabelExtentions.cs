using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdpMibTreeManager
{
    public static class LabelExtentions
    {
        public static void RefreshLabel(this Label label, string s)
        {
            if (label.InvokeRequired)
                label.Invoke((Action)(() => RefreshLabel(label, s)));
            else
                label.Text = s;
        }
    }
}
