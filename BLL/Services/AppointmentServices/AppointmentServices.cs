using Clinic.DAL;

namespace Clinic.BL;
public class AppointmentServices : IAppointmentServices
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IPatientServices _patientServices;

    public AppointmentServices(IUnitOfWork unitOfWork, IPatientServices patientServices)
    {
        _unitOfWork = unitOfWork;
        _patientServices = patientServices;
    }
    public List<AppointmentViewModel> GetAllActors()
    {
        var appointments = _unitOfWork.AppointmentRepo.GetAllActors();

        return appointments.Select(a => new AppointmentViewModel
        {
            Date = a.Date,
            Time = a.Time,
            PatientName = a.Patient.Name,
            DoctorName = a.Doctor.Name,
        }).ToList();
    }

    public Appointment AddAppointment(Appointment appointment)
    {
        _unitOfWork.AppointmentRepo.Add(appointment);
        _unitOfWork.AppointmentRepo.SaveChanges();
        return appointment;
    }

    public async Task<bool> AddAppointmentAndPatient(CreateAppointmentViewModel model)
    {
        var doctor = _unitOfWork.DoctorRepo.GetFirst(model.DoctorName);
       if(doctor == null)
        {
            return false;
        }
        
        var existingAppointment = await _unitOfWork.AppointmentRepo.GetFirst
            (new DoctorAppointment { DoctorName = model.DoctorName, AppointmentDate = model.AppointmentDate, AppointmentTime = model.AppointmentTime });
        if (existingAppointment != null)
        {
            return false;
        }

      
        var patient = new Patient
        {
            Name = model.PatientName,
            BirthDate = model.PatientBirthDate,
            Phone = model.PatientPhone
        };
        _patientServices.AddPatient(patient);
        _unitOfWork.AppointmentRepo.SaveChanges();

      
        var appointment = new Appointment
        {
            Date = model.AppointmentDate,
            Time = model.AppointmentTime,
            DoctorId = doctor.DoctorId,
            PatientId = patient.PatientId
        };
        this.AddAppointment(appointment);
        _unitOfWork.AppointmentRepo.SaveChanges();

        return true;

    }
}

