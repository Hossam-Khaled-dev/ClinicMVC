using Clinic.DAL;
using Microsoft.EntityFrameworkCore;



public class AppointmentRepo : GenericRepo<Appointment>, IAppointmentRepo
{
    private readonly ClinicContext _context;

    public AppointmentRepo(ClinicContext context) : base(context)
    {
        _context = context;
    }
    public List<Appointment> GetAllActors()
    {
        return _context.Appointments
             .Include(a => a.Patient)
             .Include(a => a.Doctor)
             .ToList();
    }
    public async Task<Appointment> CreateAppointment(Appointment appointment)
    {
        _context.Appointments.Add(appointment);
        await _context.SaveChangesAsync();
        return appointment;
    }

    public async Task<Appointment> GetFirst(DoctorAppointment model)
    {
        var appointment= await _context.Appointments.FirstOrDefaultAsync(a => a.Doctor.Name == model.DoctorName && a.Date == model.AppointmentDate && a.Time == model.AppointmentTime);
        return appointment;
    }
}

