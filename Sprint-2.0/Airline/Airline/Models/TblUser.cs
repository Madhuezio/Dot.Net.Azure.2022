using System;
using System.Collections.Generic;

#nullable disable

namespace Airline.Models
{
    public partial class TblUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? IsDeleted { get; set; }
        public int? CreatedOn { get; set; }
        public DateTime? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
