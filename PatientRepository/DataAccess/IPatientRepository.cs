using Models;
using System.Collections.Generic;
namespace DataAccess
{
    public interface IPatientRepository
    {
        void AddPatientRecord(Patients patient);  
        void UpdatePatientRecord(Patients patient);  
        void DeletePatientRecord(string id);  
        Patients GetPatientSingleRecord(string id);  
        List<Patients> GetPatientRecords();  
    }
}