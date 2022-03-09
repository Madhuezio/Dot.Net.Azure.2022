using System;
using System.Collections.Generic;

#nullable disable

namespace WEBAPI_EE.Models
{
    public partial class DepartmentTable
    {
        public int Id { get; set; }
        public int? DepartmentId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? IsDeleted { get; set; }
    }
}
