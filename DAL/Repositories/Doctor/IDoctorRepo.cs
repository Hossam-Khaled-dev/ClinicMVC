namespace Clinic.DAL;

public interface IDoctorRepo : IGenericRepo<Doctor>
{
    List<Appointment> GetDoctorAppointMent(int id);
    Doctor GetFirst(String name);

}

