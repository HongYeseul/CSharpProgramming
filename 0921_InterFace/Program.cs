using System;
using System.Diagnostics.Tracing;
using System.IO;
using System.Threading;

namespace _0921_InterFace
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0}{1}", DateTime.Now.ToLocalTime(), message);
        }
    }

    class FileLogger : ILogger
    {
        private StreamWriter writer;
        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }
        public void WriteLog(string message)
        {
            writer.WriteLine( DateTime.Now.ToShortTimeString() +" "+ message);
        }
    }

    class ClimateMonitor
    {
        private ILogger logger;
        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }
        public void start()
        {
            while (true)
            {
                Console.Write("온도를 입력해 주세요.");
                String temperature = Console.ReadLine();
                if (temperature == "")
                    break;

                logger.WriteLog("현재온도 : " + temperature);

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClimateMonitor monitor = new ClimateMonitor( new FileLogger("MyLog.txt"));
            monitor.start();
        }
    }
}
