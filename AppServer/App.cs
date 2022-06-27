using L1;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace AppServer
{
    public static class App
    {
        public static bool Trial = true;
        public static L2.ZYXDatabase Db { get; private set; }
        public static L2.Models.Teacher Teacher { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.ThreadException += Application_ThreadException;

            string allowLog = (ConfigurationSettings.AppSettings["allowLog"] + "").ToLower();
            List<string> allowLogs = new List<string>{"true", "yes", "y", "1"};
            L1.Logger.LogEnabled = allowLogs.IndexOf(allowLog) >= 0;
            if (L1.Logger.LogEnabled)
            {
                int logLevel;
                int.TryParse(ConfigurationSettings.AppSettings["logLevel"], out logLevel);
                L1.Logger.LogLevel = logLevel;
            }
            // init database
            string dbSource = ConfigurationSettings.AppSettings["dbSource"];
            string dbName = ConfigurationSettings.AppSettings["dbName"];
            string userName = ConfigurationSettings.AppSettings["userName"];
            string password = ConfigurationSettings.AppSettings["password"];            

            L1.Logger.LogLevel1(string.Format("Init database with dbsource={0}, dbName={1}", dbSource, dbName));
            Db = new L2.ZYXDatabase(dbSource, dbName, userName, password);
            L1.Logger.LogLevel1("Init database complete.");

            // start app
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            L1.Logger.LogLevel1("Log in...");
            Application.Run(new frmLogin());
            if (App.Teacher == null)
            {
                L1.Logger.LogLevel1("Login failure...");
                Environment.Exit(-1);
            }
            L1.Logger.LogLevel1("Running app...");
            Application.Run(new frmServer());
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
