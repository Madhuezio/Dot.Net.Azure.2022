using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqDemo
{
    //aggregation operators

    //aggregate
    //average
    //count
    //longcount
    //max
    //min
    //sum
    class AggregateOp
    {
        static void Main8()
        {
            //Aggregate
            IList<string> strList = new List<string>() { "one", "two", "three", "four" };
            var commasepartedstring = strList.Aggregate((s1, s2) => s1 + " | " + s2);
            Console.WriteLine(commasepartedstring);

            //Average
            IList<int> AvgList = new List<int>() { 10, 15, 35, 45, 75, 95 };
            var avg = AvgList.Average();
            Console.WriteLine("Average: {0}", avg);

            //Count
            IList<int> ConList = new List<int>() { 10, 21, 30, 45, 50 };
            var totalElements = ConList.Count();
            Console.WriteLine("Total Elements: {0}", totalElements);

            //Max
            IList<int> MaxList = new List<int>() { 10, 21, 45, 65, 75, 99 };
            var largest = MaxList.Max();
            Console.WriteLine("Largest Element: {0}", largest);

            //Min
            IList<int> MinList = new List<int>() { 5, 10, 20, 25, 75, 95 };
            var smallest = MinList.Min();
            Console.WriteLine("Smallest Element: {0}", smallest);

            //Summ
            IList<int> SumList = new List<int>() { 10, 25, 30, 45, 50, 99 };
            var total = SumList.Sum();
            Console.WriteLine("Sum: {0}", total);
        }
    }
}
