using MedicalAppAPI.Core.Dtos;
using MedicalAppAPI.Core.Services;
using MedicalAppAPI.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace MedicalAppAPI.Controllers
{
    [ApiController]
    [Route("api/patients")]
    public class PatientController : Controller
    {
       private PatientService patientService {  get; set; }

       public PatientController (PatientService patientService)
       {
            this.patientService = patientService;
       }

        [HttpGet("/get-all")]
        public ActionResult<List<Patient>> GetAll()
        {
            var results = patientService.GetAll();
            return Ok(results);
        }

        [HttpGet("/get/{patientId}")]
        public ActionResult<Patient> GetById(int patientId)
        {
            var result = patientService.GetById(patientId);

            if (result == null)
            {
                return BadRequest("Patient not fount!");
            }

            return Ok(result);
        }

        [HttpPatch("edit-name")]
        public ActionResult<bool> GetById([FromBody] PatientUpdateDto patientUpdateModel)
        {
            var result = patientService.EditName(patientUpdateModel);

            if (!result)
            {
                return BadRequest("Patient could not be updated.");
            }

            return result;
        }

        [HttpDelete("/delete-patient/{patientId}")]
        public ActionResult<bool> Delete(int patientId)
        {
            bool deleted = patientService.DeletePatient(patientId);
            if (deleted)
                return Ok("Deleted succesfully");
            return BadRequest("Couldn't delete the patient");

        }

        [HttpPut("/create-patient")]
        public ActionResult<bool> CreatePatient([FromBody] Patient patient)
        {
            bool created = patientService.CreatePatient(patient);
            if (created)
                return Ok("Created succesfully");

            return BadRequest("Couldn't create a new patient!");
        }


    }
}
