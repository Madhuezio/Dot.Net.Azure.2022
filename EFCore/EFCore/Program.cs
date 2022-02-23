using EFCore.Models;
using System;
using System.Linq;

namespace EFCore
{
    class Program
    {
        static void Main(string[] args)
        {

            //insertion
            //var context = new SampleContext();

            //Employeedepartmentmapping emp = new Employeedepartmentmapping();
            //emp.DepartmentId = 101;
            //emp.EmployeeId = 01;
            //context.Employeedepartmentmappings.Add(emp);
            //context.SaveChanges();

            //--for updation

            //var employeeData = context.EmployeeDetails.Where(x => x.Id == 1).FirstOrDefault();
            //employeeData.Gender = "Female";
            //employeeData.Employeename = "Kumari";
            //context.EmployeeDetails.Update(employeeData);
            //context.Entry(employeeData).State = EntityState.Modified;
            //context.SaveChanges();

            //--for delete
            //var employeeData = context.Employeedepartmentmappings.Where(x => x.Id == 1).FirstOrDefault();
            //context.Employeedepartmentmappings.Remove(employeeData);
            //context.SaveChanges();
            //var data = context.Employeedepartmentmappings.ToArray();

            //var context = new SampleContext();
            //var data = context.Employeedepartmentmappings.ToArray();
            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.EmployeeId);
            //    Console.WriteLine(item.DepartmentId);
            //    Console.WriteLine("===========");
            //}




            Console.ReadLine();
        }
    }
}
