using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
    class EmpExObjInitializer
    {
        static void Main2(string[] args)
        {
            //Object Initialzier
            Employee emp = new Employee()
            {
                EmployeeID = 1,
                EmployeeName = "Madhu",
                Age = 23,
                Address = "Hyderabad "
            };
            Console.WriteLine("Employee Information");
            Console.WriteLine(emp.EmployeeID);
            Console.WriteLine(emp.EmployeeName);
            Console.WriteLine(emp.Age);
            Console.WriteLine(emp.Address);
        }
    }
}
