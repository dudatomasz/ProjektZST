using Lextm.SharpSnmpLib;
using Lextm.SharpSnmpLib.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace UdpMibTreeManager
{
    public partial class Form1 : Form
    {

        private bool temp=false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var result = Messenger.GetTable(VersionCode.V2, 
                new IPEndPoint(IPAddress.Parse("127.0.0.1"), 161),
                new OctetString("ProjektZST"),
                new ObjectIdentifier(".1.3.6.1.2.1.4.21"),
                10000, 1000, null);
#pragma warning restore CS0618 // Type or member is obsolete

            var list1 = new List<string>();
            var list2 = new List<string>();

            int n = result.GetUpperBound(0)+1;
            for (int i = 0; i < n; i++)
            {
                list1.Add(result[i, 0].Data.ToString());
                list2.Add(result[i, 1].Data.ToString());
            }
            var list3 = new List<string[]>();
            for (int i = 0; i < list1.Count; i++)
            {
                list3.Add(new string[] { list1[i], list2[i] });
            }

            var dt = ConvertListToDataTable(list3);
            dataGridView1.DataSource = dt;
            
        }
        static DataTable ConvertListToDataTable(List<string[]> list)
        {
            // New table.
            DataTable table = new DataTable();

            // Get max columns.
            int columns = 0;
            foreach (var array in list)
            {
                if (array.Length > columns)
                {
                    columns = array.Length;
                }
            }

            // Add columns.
            for (int i = 0; i < columns; i++)
            {
                table.Columns.Add();
                table.Columns[i].ColumnName = (i + 1).ToString();
            }

            // Add rows.
            foreach (var array in list)
            {
                table.Rows.Add(array);
            }

            return table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        System.Timers.Timer t;
        private void button2_Click(object sender, EventArgs e)
        {
            temp = !temp;
            if (t==null)
                t = new System.Timers.Timer();
            if (temp)
            {
                button2.Text = "stop";
                t.Interval = Convert.ToInt32(numericUpDown1.Value);
                t.Elapsed += new ElapsedEventHandler(this.Refresh);
                t.Start();

            }
            else
            {
                t.Stop();
                button2.Text = "Obserwuj";
            }

        }

        public void Refresh(object sender, EventArgs e)
        {
            string oid = textBox1.Text;
            GetValue(oid);
        }

        public void GetValue(string oid)
        {
            var result = Messenger.Get(VersionCode.V1,
                           new IPEndPoint(IPAddress.Parse("127.0.0.1"), 161),
                           new OctetString("ProjektZST"),
                           new List<Variable> { new Variable(new ObjectIdentifier(oid)) },
                           10000);
            LabelExtentions.RefreshLabel(label7,result[0].Data.ToString());
                
        }
        
        
        

        
    }
}
