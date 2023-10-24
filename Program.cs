
void TemperatureConverter()
{
    try
    {
        Console.WriteLine("=======This is a simple app that converts temperatures between Celsius and Fahrenheit======");
        Console.Write("Choose an option\n \t1. Convert from Celsius to Fahrenheit.\n \t2. Convert from Fahrenheit to Celsius.\n\t3. Exit.\nEnter option: ");
        int option = int.Parse(Console.ReadLine()!);
        switch(option)
        {
            case 1:
                Console.Write("Enter Celsius Value: ");
                double Celsius = double.Parse(Console.ReadLine()!);
                double Fahrenheit = (Celsius * (9/5)) + (double)32;
                Console.WriteLine($"Fahrenheit is : {Fahrenheit}");
                break;
            case 2:
                Console.Write("Enter Fahrenheit Value: ");
                Fahrenheit = double.Parse(Console.ReadLine()!);
                Celsius = (Fahrenheit - 32) * 5/9;
                Console.WriteLine($"Celsius is: {Celsius}");
                break;
            case 3:
                Console.WriteLine("Good bye !!!");
                return;
            default:
                Console.WriteLine("Invalid Expression\nEnter a valid input.\n");
                TemperatureConverter();
            break;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        throw;
    }
    Console.WriteLine("Do you wish want to perform another Conversion? (yes/no): ");
    string respond = Console.ReadLine()!.ToLower();
    switch (respond)
    {
        case "yes":
            TemperatureConverter();
        break;
        case "no":
            Console.WriteLine("Goodbye !!!");
        return;
        default:
        Console.WriteLine("Choose an option:");
        TemperatureConverter();
        break;
    }
}
TemperatureConverter();