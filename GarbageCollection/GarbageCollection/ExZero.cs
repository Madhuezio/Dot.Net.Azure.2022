using System;
using System.Collections.Generic;
using System.Text;

namespace GarbageCollection
{
    public class ExZero
    {
        //Write a program in C# that asks the user for two numbers and shows the division and the rest of the division.
        //Notify if 0 is entered as the second number and end if 0 is entered as the first number.
        public static void Main3(string[] args)
        {
            int num1, num2;
            do
            {
                num1 = Convert.ToInt32(Console.ReadLine());
                if (num1 != 0)
                {
                    num2 = Convert.ToInt32(Console.ReadLine());
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by 0");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Division is {0}", num1 / num2);
                        Console.WriteLine("Remainder is {0}", num1 % num2);
                        Console.WriteLine();
                    }
                }
            }
            while (num1 != 0);
            Console.WriteLine("Bye!");
        }
    }
}
