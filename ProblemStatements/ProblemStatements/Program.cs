using System;

namespace ProblemStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Write a program in C# Sharp to count a total number of vowel or consonant in a string.

            /*
            string a;
            int i = 0; int L, vowels = 0, consonants = 0;
            Console.WriteLine("Count the number of vowels and consonants in a string");
            Console.WriteLine("Enter the String:");
            a = Console.ReadLine();
            L = a.Length;
            while (i < L)
            {
                if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u')
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
                i++;
            }
            Console.WriteLine("The given string contains the vowels are={0}", vowels);
            Console.WriteLine("THe Given string contains the Consonants are={0}", consonants);
            Console.ReadLine();

            */

            //2. Write a program in C# Sharp to read a sentence and replace lowercase characters by uppercase and vice-versa.

            string a;
            char[] b; char c;
            int i, L;
            Console.WriteLine("Replace LowerCase Letters by UpperCase and Vice Versa");
            Console.WriteLine("Enter the input string");
            a = Console.ReadLine();
            L = a.Length;
            b = a.ToCharArray(0, L);
            for (i = 0; i < L; i++)
            {
                c = b[i];
                if (char.IsLower(c))
                    Console.Write(char.ToUpper(c));
                else
                    Console.Write(char.ToLower(c));
            }
            Console.ReadLine();
        }
    }
}
