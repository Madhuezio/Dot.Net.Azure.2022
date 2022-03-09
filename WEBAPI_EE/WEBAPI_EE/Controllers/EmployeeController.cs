using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPI_EE.Models;
using WEBAPI_EE.ViewModels1;

namespace WEBAPI_EE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;

        private readonly HRMSContext _hrmscontext;

        public EmployeeController(ILogger<EmployeeController> logger, HRMSContext hrmscontext)
        {
            _logger = logger;
            _hrmscontext = hrmscontext;
        }
        [HttpGet]
        [Route("get-employee")]
        public IEnumerable<EmployeeH> GetEmployee()
        {
            return _hrmscontext.EmployeeHs;
        }
        [HttpPost]
        [Consumes("application/x-www-form-urlencoded")]
        [Route("save-employee")]
        public void SaveEmployee([FromForm]Employee employee)
        {

            //creating employee
            var employeeData = new EmployeeH();

            employeeData.FirstName = employee.FirstName;
            employeeData.LastName = employee.LastName;
            employeeData.EmailId = employee.EmailID;
            employeeData.AlternativeEmailId = employee.AlternateEmailId;
            employeeData.Gender = (employee.Gender.ToString() == "male") ? 1 : 0;
            employeeData.Age = employee.Age;
            employeeData.Salary = employee.Salary;
            employeeData.DateofBirth = employee.DOB;
            employeeData.DateofJoining = employee.DOJ;
            employeeData.CreatedOn = DateTime.Now;
            employeeData.UpdatedOn = DateTime.Now;
            employeeData.IsDeleted = 0;
            _hrmscontext.EmployeeHs.Add(employeeData);
            _hrmscontext.SaveChanges();
            employeeData.EmployeeId = "CAP" + employeeData.Id;
            employeeData.Createdby = employeeData.Id;
            employeeData.UpdatedBy = employeeData.Id;
            _hrmscontext.SaveChanges();

            //creating user login
            var UserLogin = new LoginTable();
            UserLogin.CreatedOn = DateTime.Now;
            UserLogin.IsDeleted = 0;
            UserLogin.UpdatedOn = DateTime.Now;
            UserLogin.Username = employee.EmailID;
            UserLogin.Password = employee.DOB.ToString("ddMMyyyy");
            _hrmscontext.LoginTables.Add(UserLogin);
            _hrmscontext.SaveChanges();
            employeeData.Createdby = UserLogin.Id;
            employeeData.UpdatedBy = UserLogin.Id;
            _hrmscontext.SaveChanges();
        }

    }
}
