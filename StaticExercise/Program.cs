namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature in fahrenheight");
            double fahrenheight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the temperature in celsius");
            double celsius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"If it is {fahrenheight} degrees in fahrenheight, that will be {TempConverter.FahrenheitToCelsius(fahrenheight)} degrees celsius" );
            Console.WriteLine($"If it is {celsius} degrees in celcius, that will be {TempConverter.CelsiusToFahrenheit(celsius)} degrees fahrenheight");
        }
    }
}
