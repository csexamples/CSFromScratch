using System;

namespace StaticMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string selection = string.Empty;

            while (selection != "Q" && selection != "q")
            {
                Console.Write("Enter C)elsius to Fahrenheit or F)ahrenheit to Celsius or Q)uit: ");
                selection = Console.ReadLine();
                double fahrenheit, celsius = 0;

                switch (selection)
                {
                    case "C":
                    case "c":
                        Console.Write("Please enter the Celsius temperature: ");
                        fahrenheit = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine());
                        Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:f2}");
                        break;
                    case "F":
                    case "f":
                        Console.Write("Please enter the Fahrenheit temperature: ");
                        celsius = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                        Console.WriteLine($"Temperature in Celsius: {celsius:f2}");
                        break;
                    case "Q":
                    case "q":
                        break;
                    default:
                        Console.WriteLine("Please try again");
                        break;
                }
            }
        }
    }
}
