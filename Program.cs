using System;

class Program
{
    public static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public static double FahrenheitToCelsius(double fahrenheit)
    {
        return (5.0 / 9) * (fahrenheit - 32);
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");

            
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter temperature in Fahrenheit: ");
                    if (double.TryParse(Console.ReadLine(), out double fTemp))
                    {
                        Console.WriteLine("Temperature in Celcius: " + FahrenheitToCelsius(fTemp) + " °C");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter a valid number.");
                    }
                    break;

                case 2:
                    Console.Write("Enter temperature in Celsius: ");
                    if (double.TryParse(Console.ReadLine(), out double cTemp))
                    {
                        Console.WriteLine("Temperature in Fahrenheit: " + CelsiusToFahrenheit(cTemp) + " °F");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter a valid number.");
                    }
                    break;

                case 0:
                    Environment.Exit(0);
                    return;

                default:
                    Console.WriteLine("Invalid choice! Please enter 0, 1, or 2.");
                    break;
            }
        }
    }
}
