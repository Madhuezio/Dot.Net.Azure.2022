using AirlineMgmt.Models;
using AirlineMgmt.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirlineMgmt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        AirlineContext _airlineContext;

        public TblBookingDetail BookingData { get; private set; }

        public BookingController(AirlineContext airlineContext)
        {
            _airlineContext = airlineContext;
        }
        [HttpGet]
        public IEnumerable<TblBookingDetail> GetFlightDetails()
        {
            return _airlineContext.TblBookingDetails.ToList();
        }
        [HttpPost]
        [Route("AddUserDetails")]
        [Consumes("application/x-www-form-urlencoded")]
        public string AddFlightDetails([FromForm] BookingDetails booking)
        {
            var BookingData = new TblBookingDetail();

            BookingData.Pnr = booking.Pnr;
            BookingData.SeatBooking = booking.SeatBooking;
            BookingData.Payment = booking.Payment;
            BookingData.Class = booking.Class;
            BookingData.ArrivalTime = booking.ArrivalTime;
            BookingData.DepatureTime = booking.DepatureTime;
            BookingData.TicketConformation = booking.TicketConformation;
            _airlineContext.TblBookingDetails.Add(BookingData);
            _airlineContext.SaveChanges();
            return "Booking details registered";
        }
    }
}
