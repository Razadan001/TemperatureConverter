using TemperatureConverter;

class Program
{
    public static void Main()
    {
        try
        {   
                Console.WriteLine("======= This is a simple app that converts temperatures between Celsius and Fahrenheit ======");
                Converter.TemperatureConverter();
        }
        catch (Exception e)
        {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ResetColor();
                Converter.TemperatureConverter();
        }
    }
}