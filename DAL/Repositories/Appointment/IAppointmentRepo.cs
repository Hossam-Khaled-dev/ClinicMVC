namespace Clinic.DAL;

public interface IAppointmentRepo : IGenericRepo<Appointment>
{
    List<Appointment> GetAllActors();
    Task<Appointment> CreateAppointment(Appointment appointment);
    Task<Appointment> GetFirst(DoctorAppointment model);
}

