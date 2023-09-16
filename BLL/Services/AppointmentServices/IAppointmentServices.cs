using Clinic.DAL;

namespace Clinic.BL;

public interface IAppointmentServices
{
    List<AppointmentViewModel> GetAllActors();
    public Appointment AddAppointment(Appointment appointment);
    public Task<bool> AddAppointmentAndPatient(CreateAppointmentViewModel model);


}

