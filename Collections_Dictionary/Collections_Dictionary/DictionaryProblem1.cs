using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Dictionary
{
    class DictionaryProblem1
    {
        static void Main5(string[] args)
        {
            Console.Write("Enter the string : ");
            string message = Console.ReadLine();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char ch in message.Replace(" ", string.Empty))
            {
                if (dict.ContainsKey(ch))
                {
                    dict[ch] = dict[ch] + 1;
                }
                else
                {
                    dict.Add(ch, 1);
                }
            }
            foreach (var item in dict.Keys)
            {
                Console.WriteLine(item + " : " + dict[item]);
            }
            Console.ReadKey();
        }
    }
}
