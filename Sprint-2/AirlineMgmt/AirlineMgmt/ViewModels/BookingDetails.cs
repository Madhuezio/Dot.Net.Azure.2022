using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirlineMgmt.ViewModels
{
    public class BookingDetails
    {
        public string Pnr { get; set; }
        public string SeatBooking { get; set; }
        public decimal? Payment { get; set; }
        public string Class { get; set; }
        public DateTime? DepatureTime { get; set; }
        public DateTime? ArrivalTime { get; set; }
        public int? TicketConformation { get; set; }
    }
}
