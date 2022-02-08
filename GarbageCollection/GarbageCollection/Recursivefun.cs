using System;
using System.Collections.Generic;
using System.Text;

namespace GarbageCollection
{
    public class Recursivefun
    {
        public static void Main6(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(IsPalindrome(text));
        }

        public static bool IsPalindrome(string text)
        {
            if (text.Length <= 1)
            {
                return true;
            }
            else
            {
                if (text[0] != text[text.Length - 1])
                {
                    return false;
                }
                else
                {
                    return IsPalindrome(text.Substring(1, text.Length - 2));
                }
            }
        }
    }
}
