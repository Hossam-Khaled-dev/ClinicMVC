namespace Clinic.DAL;

public class AppointmentViewModel
{
    public DateTime Date { get; set; }
    public DateTime Time { get; set; }
    public string PatientName { get; set; }
    public string DoctorName { get; set; }
}