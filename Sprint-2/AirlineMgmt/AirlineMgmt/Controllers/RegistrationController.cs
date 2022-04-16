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
    public class RegistrationController : ControllerBase
    {
        AirlineContext _airlineContext;

        public RegistrationController(AirlineContext airlineContext)
        {
            _airlineContext = airlineContext;
        }
        [HttpGet]
        public IEnumerable<TblUserDetail> GetTblUserDetails()
        {
            return _airlineContext.TblUserDetails.ToList();
        }
        [HttpPost]
        [Route("AddUserDetails")]
        [Consumes("application/x-www-form-urlencoded")]
        public void AddUserDetails([FromForm] UserDetails user)
        {
            var UserData = new TblUserDetail();

            UserData.FirstName = user.FirstName;
            UserData.LastName = user.LastName;
            UserData.Gender = user.Gender;
            UserData.Email = user.Email;
            UserData.UserId = user.UserId;
            UserData.CreatedOn = DateTime.Now;
            UserData.UpdatedOn = DateTime.Now;
            UserData.IsDeleted = 0;
            _airlineContext.TblUserDetails.Add(UserData);
            _airlineContext.SaveChanges();
            //return "registered successfully";

            //creating user login
            var UserLogin = new TblUser();

            UserLogin.CreatedOn = UserLogin.CreatedOn;
            UserLogin.IsDeleted = 0;
            UserLogin.UpdatedOn = DateTime.Now;
            UserLogin.UserName = user.Email;
            UserLogin.Password = user.UserId.ToString();
            _airlineContext.TblUsers.Add(UserLogin);
            _airlineContext.SaveChanges();
            UserData.CreatedBy = UserLogin.Id;
            UserData.UpdatedBy = UserLogin.Id;
            _airlineContext.SaveChanges();
        }
    }
}
