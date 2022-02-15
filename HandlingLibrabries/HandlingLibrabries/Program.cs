using System;
using Calculator;

namespace HandlingLibrabries
{
    class Program
    {
        static void Main1(string[] args)
        {
            Calculate cal = new Calculate();
            Console.WriteLine(cal.sum(1, 2));
            Console.WriteLine(cal.sub(1, 2));
            Console.WriteLine(cal.mul(1, 2));
            Console.WriteLine(cal.div(1, 2));
            Console.WriteLine(cal.mod(1, 2));

        }
    }
}
