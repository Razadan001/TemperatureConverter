using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    public class Converter
    {
        static void TemperatureConverter() 
        {
            Console.WriteLine("=======This is a simple app that converts temperatures between Celsius and Fahrenheit======");
            Console.Write("Choose an option\n \t1. Convert from Celsius to Fahrenheit.\n \t2. Convert from Fahrenheit to Celsius.\nEnter option: ");
            int option = int.Parse(Console.ReadLine()!);
    
            switch(option)
            {
                case '1':
                    Console.Write("Enter Celsius Value: ");
                    double Celsius = double.Parse(Console.ReadLine()!);
                    double Fahrenheit = (Celsius * (9/5)) + (double)32;
                    Console.WriteLine($"Fahrenheit is : {Fahrenheit}");
                    break;
                case '2':
                    Console.Write("Enter Fahrenheit Value: ");
                    Fahrenheit = double.Parse(Console.ReadLine()!);
                    Celsius = (Fahrenheit - 32) * 5/9;
                    Console.WriteLine($"Celsius is: {Celsius}");
                    break;
            }
        }
    }
}