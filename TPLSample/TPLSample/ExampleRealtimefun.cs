using System;
using System.Collections.Generic;
using System.Text;

namespace TPLSample
{
    internal class ExampleRealtimefun
    {
        public static void EmployeeID(int empid, int exp)
        {
            Console.WriteLine(empid);
            Console.WriteLine(exp);

        }
        public static int EmpSalary(int salary)
        {
            return salary;
        }
        public static bool EmployeeName(string name)
        {
            if (name.Length > 5)
            {
                return true;

            }
            return false;
        }
        static void Main(string[] args)
        {
            Func<int, int, int> obj1 = new Func<int, int, int>(EmployeeID);
            int Result = obj1.Invoke(101, 6);

            Action<int> obj2 = new Action<int>(EmpSalary);
            obj2.Invoke(10000);

            Predicate<string> Obj3 = new Predicate<string>(EmployeeName);
            bool status = Obj3.Invoke("Vikash");
            Console.WriteLine(status);

        }
    }
}
