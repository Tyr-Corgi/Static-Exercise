using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public class TempConverter
    {
        public TempConverter()
        {

        }

        public static double FahrenheitToCelsius(double fahrenheight)
        {
            double celsius = (fahrenheight - 32) * .5555555555555556;
            return celsius;
        }
        
        public static double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheight = (celsius * 9/5) + 32;
            return fahrenheight;
        }
    }
}
