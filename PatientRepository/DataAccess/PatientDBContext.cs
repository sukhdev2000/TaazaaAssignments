using Microsoft.EntityFrameworkCore;
using Models;
namespace PatientRepository.DataAccess
{
    public class PatientDBContext:DbContext//father
    {
        //ctor then press tab
        public PatientDBContext(DbContextOptions dbContextOptions):base(dbContextOptions)  
        {

        }
        public DbSet<Patients> patients{get;set;}  //for local manipulation.
    }
}