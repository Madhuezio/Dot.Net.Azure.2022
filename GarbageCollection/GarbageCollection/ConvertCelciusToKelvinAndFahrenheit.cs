using System;
using System.Collections.Generic;
using System.Text;

namespace GarbageCollection
{
    class ConvertCelciusToKelvinAndFahrenheit
    {
        public static void Main4(string[] args)
        {
            int celsius;
            celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("kelvin= {0}", celsius + 273);
            Console.WriteLine("fahrenheit= {0}", celsius * 18 / 10 + 32);
        }
    }
}
