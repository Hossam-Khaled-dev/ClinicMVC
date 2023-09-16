using Clinic.DAL;
namespace Clinic.BL
{
    public class PatientServices : IPatientServices
    {
        private readonly IPatientRepo _productRepo;

        public PatientServices(IPatientRepo productRepo)
        {
            _productRepo = productRepo;
        }
        public Patient AddPatient(Patient patient)
        {
            _productRepo.Add(patient);
            _productRepo.SaveChanges();
            return patient;
        }

    }
}
