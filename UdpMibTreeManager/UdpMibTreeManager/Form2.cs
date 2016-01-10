using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdpMibTreeManager
{
    public partial class Form2 : Form
    {
        private List<string> messeges;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(List<string> m) : this()
        {
            messeges = m;
            messegesListBox.UpdateBox(messeges);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
      
    }
}
