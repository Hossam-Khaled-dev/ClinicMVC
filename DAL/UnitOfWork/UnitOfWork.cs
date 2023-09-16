namespace Clinic.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        public IDatabaseRepo DatabaseRepo{get;}

        public IDoctorRepo DoctorRepo{get;}

        public IAppointmentRepo AppointmentRepo{get;}

        public IPatientRepo PatientRepo{get;}
        public UnitOfWork(IPatientRepo patientRepo,IDatabaseRepo databaseRepo, IDoctorRepo doctorRepo, IAppointmentRepo appointmentRepo)
        {
            PatientRepo = patientRepo;
            DatabaseRepo = databaseRepo;
            DoctorRepo= doctorRepo;
            AppointmentRepo= appointmentRepo;
        }
    }
}
