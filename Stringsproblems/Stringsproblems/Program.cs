using System;

namespace Stringsproblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# Sharp to count a total number of alphabets, digits and special characters in a string.

            /*
             
            string str;
            int alphabet, digit, specialchar, i, l;
            alphabet = digit = specialchar = i = 0;

            Console.Write("Enter the string : ");
            str = Console.ReadLine();
            l = str.Length;

            while (i < l)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    alphabet++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    specialchar++;
                }

                i++;
            }

            Console.Write("Number of Alphabets in the string is : {0}\n", alphabet);
            Console.Write("Number of Digits in the string is : {0}\n", digit);
            Console.Write("Number of Special characters in the string is : {0}\n\n", specialchar);

            Console.ReadLine();

            */

            //Write a program in C# Sharp to extract a substring from a given string without using the library function.

            /*

           Console.Write("Please enter your word : ");
           string word = Console.ReadLine();

           Console.Write("Starting position : ");
           int start = Convert.ToInt32(Console.ReadLine());

           Console.Write("Number of letters : ");
           int numberOfLetters = Convert.ToInt32(Console.ReadLine());

           int x = word.Length - numberOfLetters;

           int end = word.Length - x;

           for (int counter = start; counter <= end; counter++)
           {
               Console.Write(word[counter]);
           }

           Console.ReadLine();

           */

            
        }
    }
}
