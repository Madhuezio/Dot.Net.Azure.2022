using FirstWebApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApi.Program
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDetails : ControllerBase
    {
        static List<Employee> employeeList = new List<Employee>();
        [Route("getEmployeedata")]
        [HttpGet]
        public List<Employee> Get()
        {
            
            //Employee Details

            //List<Employee> employeeList = new List<Employee>();
            //var emp1 = new Employee();
            //emp1.EmployeeId = 101;
            //emp1.EmployeeName = "Madhu Babu";
            //emp1.Gender = "Male";
            //emp1.Age = 566;
            //emp1.DOB = 03 / 03 / 1456;
            //employeeList.Add(emp1);

            //var emp2 = new Employee();
            //emp2.EmployeeId = 102;
            //emp2.EmployeeName = "Ezio";
            //emp2.Gender = "Male";
            //emp2.Age = 666;
            //emp2.DOB = 12 / 03 / 1356;
            //employeeList.Add(emp2);

            //var emp3 = new Employee();
            //emp3.EmployeeId = 102;
            //emp3.EmployeeName = "Mahesh";
            //emp3.Gender = "Male";
            //emp3.Age = 23;
            //emp3.DOB = 12 / 03 / 1999;
            //employeeList.Add(emp3);


            return employeeList;

        }

        [Route("RecieveEmployeeData")]
        [Consumes("application/x-www-form-urlencoded")]
        [HttpPost]
        public void RecieveEmployeeData([FromForm] Employee employeedata)
        {
            employeeList.Add(employeedata);
        }
    }
}
