using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheight)
        {
            var celsius = (fahrenheight - 32) * (5/9d);
            return celsius;
        }
        
        public static double CelsiusToFahrenheit(double celsius)
        {
            var fahrenheight = (celsius * 9/5d) + 32;
            return fahrenheight;
        }
    }
}
