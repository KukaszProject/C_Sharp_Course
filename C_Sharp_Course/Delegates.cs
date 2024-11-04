using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Delegates
{
    public delegate void LogHandler(string message);

    public class Logger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine($"Console Log: {message}");
        }


        public void LogToFile(string message)
        {
            Console.WriteLine($"File log: {message}");
        }
    }

    public static void DelegatesMain()
    {
        Logger logger = new Logger();
        
        // Creating a multicast delegate
        LogHandler logHandler = logger.LogToConsole;
        logHandler += logger.LogToFile;

        //Invoking the multicast delegate

        logHandler("Log this info!");

        foreach(LogHandler handler in logHandler.GetInvocationList())
        {
            try
            {
                handler("Event accured with error handling");
            } catch (Exception e)
            {
                Console.WriteLine($"Exception caught: {e.Message}");
            }
        }
        if(IsMethodInDelegate(logHandler, logger.LogToFile))
        {
            logHandler -= logger.LogToFile;
            Console.WriteLine("LogToFile method removed");
        }
        else
        {
            Console.WriteLine("LogToFile method not found");
        }

        InvokeSafely(logHandler, "After removing a method!");
    }

    static void InvokeSafely(LogHandler logHandler, string message)
    {
        LogHandler tempLogHandler = logHandler;
        if(tempLogHandler != null)
        {
            tempLogHandler(message);
        }
    }

    static bool IsMethodInDelegate(LogHandler logHandler, LogHandler method)
    {
        if (logHandler == null)
        {
            return false;
        }
        foreach(var d in logHandler.GetInvocationList())
        {
            if(d == (Delegate)method)
            {
                return true;
            }
        }
        return false;
    }
}