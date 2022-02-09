using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Collections_Dictionary
{
    class ListExamples
    {
        static void Main7(string[] args)
        {
            List<string> mylist = test(new List<string>(new string[] { "Abc", "cdef", "js", "php" }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
        }
        public static List<string> test(List<string> str)
        {
            IEnumerable<string> s = str.Select(x => x.ToUpper());
            return s.ToList();
        }
    }
}
