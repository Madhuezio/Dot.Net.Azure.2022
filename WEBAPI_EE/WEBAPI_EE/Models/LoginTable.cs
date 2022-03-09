using System;
using System.Collections.Generic;

#nullable disable

namespace WEBAPI_EE.Models
{
    public partial class LoginTable
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? IsDeleted { get; set; }
    }
}
