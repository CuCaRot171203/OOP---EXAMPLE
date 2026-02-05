using ENCAPSULATION.Devices;

public class Program
{
    static void Main()
    {
        ISmartDevice device;

        Console.WriteLine("Choose device: ");
        Console.WriteLine("1. Light");
        Console.WriteLine("2. Fan");
        Console.Write("Choose: ");

        string choice = Console.ReadLine()!;

        if (choice == "1")
            device = new SmartLight();
        else
            device = new SmartFan();

        device.TurnOn();

        Console.WriteLine(device.GetStatus());

        device.TurnOff();
        Console.WriteLine(device.GetStatus());

    }
}