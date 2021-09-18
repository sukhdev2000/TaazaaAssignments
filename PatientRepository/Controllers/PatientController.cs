using Microsoft.AspNetCore.Mvc;
using Models;
using DataAccess;
namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientController:ControllerBase
    {
        IPatientRepository patientRepository1;
        public PatientController(IPatientRepository patientRepository)
        {
            patientRepository1=patientRepository;
        }
        [HttpPost("Add")]
        public IActionResult CreatePatient(Patients patients)
        {
            patientRepository1.AddPatientRecord(patients);
            return Ok("Record Added!!");
        }
                [HttpPut("update")]  
        public IActionResult Edit(Patients patient)  
        {  
            if (ModelState.IsValid)  
            {  
                patientRepository1.UpdatePatientRecord(patient);  
                return Ok("Updated Successfully!!!!");  
            }  
            return BadRequest();  
        } 
        [HttpDelete("{id}")]  
        public IActionResult DeleteConfirmed(string id)  
        {  
            var data = patientRepository1.GetPatientSingleRecord(id);  
            if (data == null)  
            {  
                return NotFound();  
            }  
            patientRepository1.DeletePatientRecord(id);  
            return Ok("deleted successfully!!!");  
        }  
        [HttpGet("{id}")]
        public IActionResult Show(string id)
        {
            var DataToShow=patientRepository1.GetPatientSingleRecord(id);
            if(DataToShow==null)
            return Ok("nothing to show!!");
            else
            return Ok(DataToShow);
        } 
        [HttpGet("All")]
        public IActionResult ShowAll()
        {
            var AllData= patientRepository1.GetPatientRecords();
            return Ok(AllData);
        }
    }
}