using MiniStore.ItemNav;
using MiniStore.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore
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
            //Application.Run(new Forms.frm_Main());
            //Application.Run(new Forms.frm_Connect());
            //Application.Run(new Forms.frm_Login());
            Application.Run(new QL_Food());
            //Application.Run(new Forms.frm_Splash());
            //Application.Run(new Forms.frm_changepassword());
            //Application.Run(new Forms.frm_TTcuahang());
            //Application.Run(new Forms.frm_UserPermission());
            //Application.Run(new Forms.frm_About());
            //Application.Run(new Forms.frm_BackupDatabase());
            //Application.Run(new Forms.frm_RestoreDatabase());
        }
    }
}
