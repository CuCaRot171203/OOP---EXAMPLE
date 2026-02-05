using INHERITANCE;

public class Program
{
    static void Main()
    {
        Employee emp1 = new FulltimeEmployee
        {
            Name = "Emp1",
            MonthlySalary = 20000000,
            Insurance = 2000000
        };

        Employee emp2 = new ParttimeEmployee
        {
            Name = "Emp2",
            HourlyRate = 50000,
            HoursWorked = 80
        };

        PrintSalary(emp1);
        PrintSalary(emp2);
    }

    // Method print salary
    static void PrintSalary(Employee emp)
    {
        Console.WriteLine($"{emp.Name} has salary: {emp.CalculateSalary():N0} VND");
    }
}