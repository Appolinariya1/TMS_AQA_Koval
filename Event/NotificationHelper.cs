namespace Event;

public class NotificationHelper
{
    public void NotifyByEmail(string email)
    {
        Console.WriteLine($"Notfication was send with message {email}");
    }
}