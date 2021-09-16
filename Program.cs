using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHSTHPT.Component;

namespace QLHSTHPT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        public static frmMain1 frMain_main;
        public static string usernamelogin = "";

        [STAThread]
        static void Main()

        {
            Connetion.ConnectDB();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new D());
        }
    }
}
