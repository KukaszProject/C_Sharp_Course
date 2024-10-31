using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{

    public interface ILogger
    {
        void Log(string message);
    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            string directoryPath = @"C:\Logs";
            string filePath = System.IO.Path.Combine(directoryPath, "log.txt");

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.AppendAllText(filePath, $"{message} \n");
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void Log( string message)
        {
            //Implement the logic to log to database
            Console.WriteLine($"Logging to database. {message}");
        }
    }

    public class Application
    {
        private readonly ILogger _logger;
        public Application(ILogger logger)
        {
            _logger = logger;
        }

        public void DoWork()
        {
            _logger.Log("Work started.");
            //Do all work
            _logger.Log("Work done.");
        }
    }
    public class Logs
    {
        public static void LogsMain() 
        { 
            ILogger fileLogger = new FileLogger();
            Application app = new Application(fileLogger);
            app.DoWork();

            ILogger dbLogger = new DatabaseLogger();
            app = new Application(dbLogger);
            app.DoWork();

            Console.ReadKey();
        }
    }
}
