namespace Clinic.DAL
{
    public class PatientRepo : GenericRepo<Patient>, IPatientRepo
    {
        public PatientRepo(ClinicContext context) : base(context)
        {
        }
    }
}
