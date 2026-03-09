using System;
using System.Collections.Generic;

public class Logger
{
    private static Logger _instance;

    private List<string> logs = new List<string>();

    private Logger()
    {
    }

    public static Logger Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }
    }

    public void Log(string message)
    {
        logs.Add(message);
    }

    public void StampaLog()
    {
        foreach (var log in logs)
        {
            Console.WriteLine(log);
        }
    }
}