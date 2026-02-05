using ABSTRACTION;

public class Program
{
    static void Main()
    {
        INotificationService notifier;

        Console.WriteLine("Choose one: ");
        Console.WriteLine("1. Email");
        Console.WriteLine("2. SMS");
        Console.WriteLine("Choose: ");

        string choice = Console.ReadLine()!;

        if(choice == "1")
        {
            notifier = new EmailNotification();
        } else
        {
            notifier = new SmsNofitication();
        }

        notifier.Send("Your mail has been processed");
    }
}