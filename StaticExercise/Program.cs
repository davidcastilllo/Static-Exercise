namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The temperature in celcius is {TempConverter.FahrenheitToCelsius(70)}."); 
            Console.WriteLine($"The temperature in fahrenheit is {TempConverter.CelsiusToFahrenheit(21.111111111111)}."); 
        }
    }
}
