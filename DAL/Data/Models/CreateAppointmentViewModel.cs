using System.ComponentModel.DataAnnotations;

namespace Clinic.DAL
{
	public class CreateAppointmentViewModel 
    {

        [Required]
        public string? PatientName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime PatientBirthDate { get; set; }

        [Required]
        public string? PatientPhone { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime AppointmentTime { get; set; }

        [Required]
        public string? DoctorName { get; set; }

        
    }
}
