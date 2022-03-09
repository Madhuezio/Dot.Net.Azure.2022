using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI_EF.Models
{
    public partial class EmployeeTable
    {
        public int Id { get; set; }
        public string Prefix { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeGender { get; set; }
        public int? EmployeeAge { get; set; }
        public DateTime? EmployeeDob { get; set; }
        public string EmployeeEmail { get; set; }
    }
}
