using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdpMibTreeManager
{
    public static class ListBoxExtensions
    {
        public static void UpdateBox(this ListBox box, List<string> m)
        {
            if (box.InvokeRequired)
            {
                box.Invoke((Action)(() => UpdateBox(box, m)));
            }
            else
            {
                box.DataSource = m;
                box.Update();
            }
        }
    }
}
