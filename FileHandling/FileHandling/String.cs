using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace FileHandling
{
    class String
    {
        static void Main3(string[] args)
        {
            Console.WriteLine(" Enter string");
            string path = "D://.net//sample.txt";
            string Text = Console.ReadLine();
            using (StreamWriter writetext = new StreamWriter(path))
            {
                writetext.WriteLine(Text);
            }
            string text = File.ReadAllText(@"D://.net//sample.txt", Encoding.UTF8);
            //Console.WriteLine(text);
            string s = text.Trim();
            string revs = "";
            for (int i = s.Length - 1; i >= 0; i--) //String Reverse  
            {
                revs += s[i].ToString();
            }
            if (revs == s) // Checking whether string is palindrome or not  
            {
                Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
            }
            else
            {
                Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
            }

        }
    }
}
