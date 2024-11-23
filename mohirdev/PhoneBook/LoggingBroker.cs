namespace mohirdev.PhoneBook;

public class LoggingBroker
{
    public void Log(string message)
    {
        Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] | INFO: {message}");
    }

    public void LogError(string message)
    {
        Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] | ERROR: {message}");
    }
}