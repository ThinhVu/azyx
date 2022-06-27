using System;
using System.Diagnostics;
using System.IO;

namespace L1
{    
    public class Logger
    {
        public const string LOG_FILE = "log.txt";
        public static bool LogEnabled = false;
        public static int LogLevel = 0; // NoLog

        static Logger()
        {
            // clear log file each time app run
            try
            {
                if (File.Exists(LOG_FILE))
                    File.Delete(LOG_FILE);
            }
            catch
            {
            }
        }

        public static void Log(Exception ex)
        {
            try
            {
                string msg =
                    "Exception:" + DateTime.Now.ToString() + Environment.NewLine +
                    "\tMessage:" + ex.Message + Environment.NewLine +
                    "\tStackTrace:" + ex.StackTrace + Environment.NewLine + Environment.NewLine;
                using (var sw = File.AppendText(LOG_FILE))
                {
                    sw.Write(msg);
                }
            }
            catch
            {
            }
        }

        private static void log(string msg)
        {           
            try
            {
                if (!LogEnabled) return;
                using (var sw = File.AppendText("log.txt"))
                {
                    sw.Write(string.Format("{0}{1}{2}", callInfor(), msg, Environment.NewLine));
                }
            }
            catch
            {
            }
        }
        /// <summary>
        /// For logging important information
        /// Main flow
        /// </summary>
        /// <param name="msg"></param>
        public static void LogLevel1(string msg)
        {
            if (LogLevel == 0) return;
            if (1 <= LogLevel) log(msg);
        }
        /// <summary>
        /// Sub-main flow
        /// </summary>
        /// <param name="msg"></param>
        public static void LogLevel2(string msg)
        {
            if (LogLevel == 0) return;
            if (2 <= LogLevel) log(msg);
        }
        /// <summary>
        /// Verbose log - log everything
        /// </summary>
        /// <param name="msg"></param>
        public static void LogLevel3(string msg)
        {
            if (LogLevel == 0) return;
            if (3 <= LogLevel) log(msg);
        }

#if DEBUG
        private static string callInfor()
        {
            // skip 3 stackframe
            // current method
            // Log method
            // LogLevel method
            StackFrame callStack = new StackFrame(3, true);
            return string.Format("{0} {1}::{2} ({3}, {4}): ",
                DateTime.Now.ToString(),  // 0
                callStack.GetMethod().DeclaringType.Name, // 1
                callStack.GetMethod().Name, // 2
                Path.GetFileName(callStack.GetFileName()),  // 3
                callStack.GetFileLineNumber()); // 4
        }
#else
        private static string callInfor()
        {
            return DateTime.Now.ToString() + ": ";
        }
#endif
    }
}
