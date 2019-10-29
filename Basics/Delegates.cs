using System;
using System.IO;

namespace Basics
{
    public class Log
    {
        private class Logger : IDisposable
        {
            private readonly FileStream fileStream;
            private readonly StreamWriter streamWriter;

            public Logger()
            {
                fileStream = new FileStream("delegates_" + DateTime.Now.ToString("yyyy-MM-dd-ss") + ".log", FileMode.Create);
                streamWriter = new StreamWriter(fileStream);
            }

            public void Dispose()
            {
                streamWriter.Close();
                fileStream.Close();
            }

            public void LogToConsole(string data)
            {
                Console.WriteLine(data);
            }

            public void LogToFile(string data)
            {
                streamWriter.WriteLine(data);
            }
        }
        private readonly Logger logger;

        public delegate void LogErrorDelegate(string data);

        private readonly LogErrorDelegate logError;
        public LogErrorDelegate LogError
        {
            get { return logError; }
            private set { }
        }

        public Log()
        {
            logger = new Logger();
            logError += logger.LogToConsole;
            logError += logger.LogToFile;
        }
    }
}
