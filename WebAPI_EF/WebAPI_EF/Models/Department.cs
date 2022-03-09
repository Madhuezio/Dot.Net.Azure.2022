using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI_EF.Models
{
    public partial class Department
    {
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int? EmployeeId { get; set; }
    }
}
