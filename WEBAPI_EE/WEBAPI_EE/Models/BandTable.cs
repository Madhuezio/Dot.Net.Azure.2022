using System;
using System.Collections.Generic;

#nullable disable

namespace WEBAPI_EE.Models
{
    public partial class BandTable
    {
        public int Id { get; set; }
        public string BandName { get; set; }
        public int? BandStartRange { get; set; }
        public int? BandEndRange { get; set; }
        public int? Createdby { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? IsDeleted { get; set; }
    }
}
