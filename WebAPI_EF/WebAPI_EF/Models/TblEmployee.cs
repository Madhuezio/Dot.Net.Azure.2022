using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI_EF.Models
{
    public partial class TblEmployee
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int? Age { get; set; }
        public int? Salary { get; set; }
        public string Gender { get; set; }
        public int? IsDeleted { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
