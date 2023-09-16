using Clinic.DAL;

namespace Clinic.BL;

public interface IDoctorServices
{
    public List<Doctor> GetAllDoctors();
    Doctor? GetDoctorById(int id);
    Doctor AddDoctor(Doctor doctor);
    List<Appointment> GetAllDocAppoint(int id);
}

