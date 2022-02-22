using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqDemo
{
    public class Employee
    {
        public int id;
        public string name;
        public int dept_id;
        public int add_id;
    }
    public class Department
    {
        public int dept_id;
        public string dept_name;
    }
    class Problem1
    {
        static void Main(string[] args)
        {

           
            List<Employee> employees = new List<Employee>()
            {
                 new Employee{ id = 123, name = "madhu babu",
                      dept_id = 1},
                 new Employee{ id = 456, name = "Edward",
                      dept_id = 2},
                 new Employee{ id = 789, name = "Ezio",
                      dept_id = 1},
                 new Employee{ id = 533, name = "Mihawk",
                      dept_id = 4},
            };

            List<Department> departments = new List<Department>()
             {
                  new Department{ dept_id = 1, dept_name = "CSE" },
                  new Department{ dept_id = 2, dept_name = "ECE" },
                  new Department{ dept_id = 3, dept_name = "IT " },
             };

            var result = (from stu in employees

                          join dept in departments on stu
                          .dept_id equals dept
                          .dept_id

                          select new
                          {
                              ID = stu.id,
                              Name = stu.name,
                              DeptName = dept.dept_name,
                          }).ToList();

            foreach (var e in result)
            {
                Console.WriteLine("ID: " + e.ID +
                            "--> Name: " + e.Name +
                      "--> Department: " + e.DeptName);
            }
        }
    }
}
