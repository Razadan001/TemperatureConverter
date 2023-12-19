
namespace TemperatureConverter
{
    public class Converter
    {
        public static void TemperatureConverter()
{
        Console.Write("Choose an option\n1. Convert from Celsius to Fahrenheit.\n2. Convert from Fahrenheit to Celsius\n3.Exit: ");
        int option = int.Parse(Console.ReadLine()!);
        switch(option)
        {
            case 1:
                Console.Write("Enter Celsius Value: ");
                double Celsius = double.Parse(Console.ReadLine()!);
                double Fahrenheit = (Celsius * (9/5)) + 32;
                Console.WriteLine($"Fahrenheit is : {Fahrenheit}F");
                Replay();
                break;
            case 2:
                Console.Write("Enter Fahrenheit Value: ");
                Fahrenheit = double.Parse(Console.ReadLine()!);
                Celsius = (Fahrenheit - 32) * 5/9;
                Console.WriteLine($"Celsius is: {Celsius} C");
                Replay();
                break;
            case 3:
                Console.WriteLine("Good bye !!!");
                break;
            default:
                Console.WriteLine("Invalid Expression\nEnter a valid input.\n");
                TemperatureConverter();
            break;
        }
    
    
}
public static void Replay(){
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
}
}