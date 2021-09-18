using System.Collections.Generic;
using Models;
using PatientRepository.DataAccess;
using System.Linq;
namespace DataAccess
{
    public class PatientsRepository : IPatientRepository
    {
        PatientDBContext patientDBContext1;
        public PatientsRepository(PatientDBContext patientDBContext)
        {
            patientDBContext1=patientDBContext;
        }
        public void AddPatientRecord(Patients patient)
        {
            patientDBContext1.Add(patient);    //add to local memory
            patientDBContext1.SaveChanges();   // will add to database
        }

          public List<Patients> GetPatientRecords()  
        {  
            return patientDBContext1.patients.ToList();  
        }

        public Patients GetPatientSingleRecord(string id)
        {
             return patientDBContext1.patients.FirstOrDefault(t => t.id == id);
        }

        public void UpdatePatientRecord(Patients patient)
        {
             patientDBContext1.patients.Update(patient);  
             patientDBContext1.SaveChanges();  
        }

      public void DeletePatientRecord(string id)  
        {  
            var entity = patientDBContext1.patients.FirstOrDefault(t => t.id == id);  
            patientDBContext1.patients.Remove(entity);  
            patientDBContext1.SaveChanges();  
        }  
    }
}