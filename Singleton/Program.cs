using System;

public class Logger
{
    private static Logger instance;
    private static readonly object lockObject = new object();

    private Logger()
    {
        // Private constructor to prevent instantiation from outside the class.
    }

    public static Logger Instance
    {
        get
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                }
            }
            return instance;
        }
    }

    public void Log(string message)
    {
        // Code to log the message goes here.
        Console.WriteLine($"Logging message: {message}");
    }
}

class Program
{
    static void Main()
    {
        Logger logger = Logger.Instance;
        logger.Log("This is a log message.");
    }
}

