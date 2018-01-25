using EntitySampleWFA.Source.BO;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace EntitySampleWFA
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Database.SetInitializer<SchoolContext>(new SchoolInitiliazer());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}