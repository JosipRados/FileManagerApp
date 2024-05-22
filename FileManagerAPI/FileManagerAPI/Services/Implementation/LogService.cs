namespace FileManagerAPI.Services.Implementation
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
