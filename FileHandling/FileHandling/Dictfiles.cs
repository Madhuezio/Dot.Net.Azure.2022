using System;
using System.Collections.Generic;
using System.Text;

namespace FileHandling
{
    class Dictfiles
    {
        static void Main4(string[] args)
        {
            // Collection initializer
            // Initializing the collection directly at the time of declaration
            Dictionary<int, Employee> dictionaryEmployees = new Dictionary<int, Employee>()
            {
                { 101, new Employee {ID=101, Name="Madhu", Gender="Male", Salary = 20000}},
                { 102, new Employee {ID=101, Name="Ezio", Gender="Male", Salary = 30000}},
                { 103, new Employee {ID=101, Name="Anurag", Gender="Male", Salary = 40000}}
            };

            //To get all the values in the dictionary use Values property
            Console.WriteLine("All employees objects in Employee Dictionary");
            foreach (Employee emp in dictionaryEmployees.Values)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender ={2}, Salary = {3}",
                               emp.ID, emp.Name, emp.Gender, emp.Salary);
            }

            Console.ReadKey();
        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }
}

