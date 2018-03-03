using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace AutoFin.Tools
{
    class Log
    {
        public static void save(object obj, Exception ex)
        {
            string date = System.DateTime.Now.ToString("yyyyMMdd");
            string time = System.DateTime.Now.ToString("HH:mm:ss");
            string path = System.AppDomain.CurrentDomain.BaseDirectory + "/log_" + date + ".txt";

            StreamWriter streamWriter = new StreamWriter(path, true);

            StackTrace stackTrace = new StackTrace();
            streamWriter.WriteLine(obj.GetType().FullName + " " + time);
            streamWriter.WriteLine(stackTrace.GetFrame(1).GetMethod().Name + " - " + ex.Message);
            streamWriter.WriteLine("");
            streamWriter.Flush();
            streamWriter.Close();
        }

        public static void save(object obj, string ex)
        {
            string date = System.DateTime.Now.ToString("yyyyMMdd");
            string time = System.DateTime.Now.ToString("HH:mm:ss");
            string path = System.AppDomain.CurrentDomain.BaseDirectory + "/log_" + date + ".txt";

            StreamWriter streamWriter = new StreamWriter(path, true);
            streamWriter.WriteLine(obj.GetType().FullName + " " + time);
            streamWriter.WriteLine(ex);
            streamWriter.WriteLine("");
            streamWriter.Flush();
            streamWriter.Close();
        }
    }
}
