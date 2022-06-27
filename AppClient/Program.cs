using L2;
using L2.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace ClientApp
{
    public static class Program
    {
        public static ZYXDatabase Database;
        public static Student Student;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            try
            {
                string allowLog = (ConfigurationSettings.AppSettings["allowLog"] + "").ToLower();
                List<string> allowLogs = new List<string> { "true", "yes", "y", "1" };
                L1.Logger.LogEnabled = allowLogs.IndexOf(allowLog) >= 0;
                if (L1.Logger.LogEnabled)
                {
                    int logLevel;
                    int.TryParse(ConfigurationSettings.AppSettings["logLevel"], out logLevel);
                    L1.Logger.LogLevel = logLevel;
                }
                string dbSource = ConfigurationSettings.AppSettings["dbSource"];
                string dbName = ConfigurationSettings.AppSettings["dbName"];
                string userName = ConfigurationSettings.AppSettings["userName"];
                string password = ConfigurationSettings.AppSettings["password"];
                L1.Logger.LogLevel1("Database connection initializing (source:" + dbSource + " -- dbname: " + dbName + ")");
                Program.Database = new ZYXDatabase(dbSource, dbName, userName, password);
                L1.Logger.LogLevel1("Database connection initializing completed.");
                while (true)
                {
                    Program.Student = null;
                    L1.Logger.LogLevel1("Log in...");
                    Application.Run(new frmLogin());
                    if (Program.Student == null)
                    {
                        L1.Logger.LogLevel1("Quit app");
                        Environment.Exit(0);
                    }
                    L1.Logger.LogLevel1("Login succeeded with student username: " + Student.Username);
                    Application.Run(new frmClient());
                }
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {                        
            L3.ExceptionDisplayer.ShowOkError(e.Exception);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            L3.ExceptionDisplayer.ShowOkError((e.ExceptionObject as Exception));            
        }
    }
}
