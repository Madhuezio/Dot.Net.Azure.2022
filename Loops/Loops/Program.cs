using System;

namespace Loops
{
    class Program
    {
        static void Main1(string[] args)
        {

            //Write a program in C# Sharp to display n terms of natural number and their sum.
            /*
              
            
            int i, n, sum = 0;

            Console.Write("\n\n");
            Console.Write("Display n terms of natural number and their sum:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input Value of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe first {0} natural number are :\n", n);
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
                sum += i;
            }
            Console.Write("\nThe Sum of Natural Number upto {0} terms : {1} \n", n, sum);

            */

            //patterns
            //1
            //2 3
            //4 5 6
            //7 8 9 10


            /*
            int i, j, rows, k = 1;

            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", k++);
                Console.Write("\n");

            }

            */

            //create a program it will take a number as a input and print the factorial of that number.

            /*
            int i, fact = 1, number;
            Console.Write("Enter any Number: ");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + number + " is: " + fact);

            */


        }
    }
}
