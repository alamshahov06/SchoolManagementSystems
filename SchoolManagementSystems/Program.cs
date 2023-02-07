using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace SchoolManagementSystems
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
          {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (File.Exists(MainClass.path + "\\connect"))
            {
                MainClass.conn = File.ReadAllText(MainClass.path+"\\connect");
                Application.Run(new login_win());
            }
            else
            {
                Application.Run(new Connection());
            }
        }
    }
}
