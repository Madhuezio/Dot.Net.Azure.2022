using System;
using System.Collections.Generic;

#nullable disable

namespace AirlineMgmt.Models
{
    public partial class TblBookingDetail
    {
        public int Id { get; set; }
        public string Pnr { get; set; }
        public string SeatBooking { get; set; }
        public decimal? Payment { get; set; }
        public string Class { get; set; }
        public DateTime? DepatureTime { get; set; }
        public DateTime? ArrivalTime { get; set; }
        public int? TicketConformation { get; set; }
    }
}
