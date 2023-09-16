using Clinic.BL;
using Clinic.DAL;



public class DoctorServices : IDoctorServices
{
    private readonly IDoctorRepo _doctorRepo;

    public DoctorServices(IDoctorRepo doctorRepo)
    {
        _doctorRepo = doctorRepo;
    }
    public Doctor AddDoctor(Doctor doctor)
    {
        _doctorRepo.Add(doctor);
        _doctorRepo.SaveChanges();
        return doctor;
    }

    public List<Appointment> GetAllDocAppoint(int id)
    {
        var Appointments=_doctorRepo.GetDoctorAppointMent(id);
        return Appointments;
    }

    public List<Doctor> GetAllDoctors()
    {
        var dbDoctors = _doctorRepo.GetAll();
        return dbDoctors;
    }

    public Doctor? GetDoctorById(int id)
    {
        var dbDoctors = _doctorRepo.GetById(id);
        if (dbDoctors == null)
        {
            return null;
        }
        return dbDoctors;
    }
}

