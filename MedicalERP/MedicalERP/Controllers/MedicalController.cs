using MedicalERP.Models;
using MedicalERP.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalERP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalController : ControllerBase
    {
        MedicalERPContext _medicalerpContext;
        public MedicalController(MedicalERPContext medicalerpContext)
        {
            _medicalerpContext = medicalerpContext;
        }
        [HttpGet]
        [Route("GetAllPatientDetails")]
        public IEnumerable<TblPatient> GetAllPatientDetails()
        {
            return _medicalerpContext.TblPatients.ToList();
        }
        [HttpPost]
        [Route("AddPatientDetails")]
        [Consumes("application/x-www-form-urlencoded")]
        public string AddPatientDetails([FromForm] Patient patient)
        {
            var PatientData = new TblPatient();

            PatientData.FirstName = patient.FirstName;
            PatientData.LastName = patient.LastName;
            PatientData.Gender = patient.Gender;
            PatientData.CreateOn = DateTime.Now;
            PatientData.UpdatedOn = DateTime.Now;
            PatientData.IsDeleted = 0;
            _medicalerpContext.TblPatients.Add(PatientData);
            _medicalerpContext.SaveChanges();

            return "record added successfully";
        }
    }
}
