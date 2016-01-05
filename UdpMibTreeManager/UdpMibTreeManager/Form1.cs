using Lextm.SharpSnmpLib;
using Lextm.SharpSnmpLib.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdpMibTreeManager
{
    public partial class Form1 : Form
    {
        private string watchedOID;
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
                new ObjectIdentifier(oidTextBox.Text),
                10000, 1000, null);
#pragma warning restore CS0618 // Type or member is obsolete

           

            var list1 = new List<string[]>();
            var list2 = new List<string[]>();
            for (int i = 0; i < result.GetLength(0); i++)
            {
                var listTmp = new List<string>();
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    listTmp.Add(result[i, j].Data.ToString());
                }
                
                list1.Add(listTmp.ToArray());
            }

            var dt = ConvertListToDataTable(list1);
            chosenTableGridView.DataSource = dt;
            
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

        private void watchObjectButton_Click(object sender, EventArgs e)
        {
            watchedOID = oidTextBox.Text;
            watchTimer.Interval = Convert.ToInt32( delayNumericUpDown.Value);
            GetValueFromOID();
            if (!watchTimer.Enabled)
                watchTimer.Start();
            else
                watchTimer.Stop();             
        }

        private string GetValueFromOID ()
        {
            var result = Messenger.Get(VersionCode.V2,
                new IPEndPoint(IPAddress.Parse("127.0.0.1"), 161),
                new OctetString("ProjektZST"),
                new List<Variable>() { new Variable(new ObjectIdentifier(watchedOID)) },
                100);
            return result[0].Data.ToString();
        }

        

        private void watchTimer_Tick(object sender, EventArgs e)
        {
                watchedValueLabel.ChangeText(GetValueFromOID());           
        }
        
    }
}
