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
    public class AdminController : ControllerBase
    {
        AirlineContext _airlineContext;

        public TblFlightDetail FlightData { get; private set; }

        public AdminController(AirlineContext airlineContext)
        {
            _airlineContext = airlineContext;
        }
        [HttpGet]
        public IEnumerable<TblFlightDetail> GetFlightDetails()
        {
            return _airlineContext.TblFlightDetails.ToList();
        }

        [HttpPost]
        [Route("AddUserDetails")]
        [Consumes("application/x-www-form-urlencoded")]
        public string AddFlightDetails([FromForm] FlightDetails flight)
        {
            var FlightData = new TblFlightDetail();

            FlightData.FlightName = flight.FlightName;
            FlightData.Source = flight.Source;
            FlightData.Destination = flight.Destination;
            FlightData.ArrivalTime = flight.ArrivalTime;
            FlightData.DepatureTime = flight.DepatureTime;
            FlightData.FlightCharges = flight.FlightCharges;
            FlightData.AvailableSeats = flight.AvailableSeats;
            FlightData.TotalSeats = flight.TotalSeats;
            _airlineContext.TblFlightDetails.Add(FlightData);
            _airlineContext.SaveChanges();
            return "successfully added flight details";
        }
    }
}
