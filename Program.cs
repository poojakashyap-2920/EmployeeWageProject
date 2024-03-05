using System;

public class EmployeeWageCalculator
{
    public static void Main(string[] args)
    {
        while (true)
        {

            Console.WriteLine("Enter the employee worked hours:");
            int hr = Convert.ToInt32(Console.ReadLine());
            int wage = 20; // Assuming wage is $20 per hour

            switch (hr)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                    Console.WriteLine($"Employee has worked {hr} hours per day & daily wage is {wage * hr}");
                    break;
                default:
                    Console.WriteLine("Invalid number of hours!");
                    break;
            }

        }
        Console.ReadLine();
    }
}
