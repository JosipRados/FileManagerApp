using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagerDesktop.Services.Implementation
{
    public class LogService : ILogService
    {
        public void WriteLog(string message)
        {
            string logPath = "logFile.txt";

            using (StreamWriter stream = new StreamWriter(logPath, true))
            {
                stream.WriteLine(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + " " + message);
            }
        }
    }
}
