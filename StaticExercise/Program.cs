namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fahrenheight = 12;
            var celsius = 40;
            Console.WriteLine($"If it is {fahrenheight} degrees in fahrenheight, that will be {TempConverter.FahrenheitToCelsius(fahrenheight)} degrees celsius" );
            Console.WriteLine($"If it is {celsius} degrees in celcius, that will be {TempConverter.CelsiusToFahrenheit(celsius)} degrees fahrenheight");
        }
    }
}
