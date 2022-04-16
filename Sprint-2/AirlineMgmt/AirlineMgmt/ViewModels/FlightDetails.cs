using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirlineMgmt.ViewModels
{
    public class FlightDetails
    {
        public string FlightName { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime? ArrivalTime { get; set; }
        public DateTime? DepatureTime { get; set; }
        public decimal? FlightCharges { get; set; }
        public int? AvailableSeats { get; set; }
        public int? TotalSeats { get; set; }
    }
}
