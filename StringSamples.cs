using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConcepts
{
    class StringSamples
    {
        static void Main(string[] args)
        {

            /*
            string s = "some value";
            s = "Vikash";
            //replace
            //split
            //startswith
            //substring
            //tolower
            //toupper
            s = s.Replace("Vikash", "1,2,3");
            var valuearray = s.Split(',');
            Console.WriteLine("Values after spliting");
            for (int i = 0; i < valuearray.Length; i++)
            {
                Console.WriteLine(valuearray[i]);
            }
            Console.WriteLine(s);
            StringBuilder sb = new StringBuilder("Hello world");
            sb.Append("Hello");
            sb.Replace("Hello", "Hello 1");
            sb.Insert(0, "New value");
            Console.WriteLine(sb);

            */

            // Check number is odd or even.

            /*
            int n;
            Console.WriteLine("Enter a number to check :");

            n = int.Parse(Console.ReadLine());
            if(n%2 == 0)
            {
                Console.WriteLine(n + "is an even number");
            }
            else
            {
                Console.WriteLine(n + "is an odd number");
            }

            */

            //Write a C# Sharp program to find whether a given year is a leap year or not


            Console.WriteLine("Enter Year : ");
            int Year = int.Parse(Console.ReadLine());
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine("{0} is a Leap Year.", Year);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year.", Year);
            }
            Console.ReadLine();
        }
    }
}
