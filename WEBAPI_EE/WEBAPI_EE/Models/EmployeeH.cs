using System;
using System.Collections.Generic;

#nullable disable

namespace WEBAPI_EE.Models
{
    public partial class EmployeeH
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public int? Age { get; set; }
        public int? Gender { get; set; }
        public string EmployeeBand { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateofBirth { get; set; }
        public DateTime? DateofJoining { get; set; }
        public int? Salary { get; set; }
        public int? Createdby { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? IsDeleted { get; set; }
        public string EmailId { get; set; }
        public string AlternativeEmailId { get; set; }
    }
}
