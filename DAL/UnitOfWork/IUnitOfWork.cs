namespace Clinic.DAL
{
    public interface IUnitOfWork
    {
        public IDatabaseRepo DatabaseRepo { get;}
        public IDoctorRepo DoctorRepo { get;}
        public IAppointmentRepo AppointmentRepo { get;}
        public IPatientRepo PatientRepo { get; }
            
    }
}
