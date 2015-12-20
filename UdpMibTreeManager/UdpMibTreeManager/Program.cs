using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lextm.SharpSnmpLib;
using Lextm.SharpSnmpLib.Messaging;
using System.Net;

namespace UdpMibTreeManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);         
            Application.Run(new Form1());*/
            var result = Messenger.Get(VersionCode.V1,
                            new IPEndPoint(IPAddress.Parse("192.168.0.11"), 161),
                            new OctetString("ProjektZST"),
                            new List<Variable> { new Variable(new ObjectIdentifier("1.3.6.1.2.1.1.1.0")) },
                            60000);
            Console.WriteLine(result[0].ToString());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Console.WriteLine();



        }
    }
}
