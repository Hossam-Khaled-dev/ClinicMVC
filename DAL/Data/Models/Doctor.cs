using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic.DAL
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
       [Required]
        public string Name { get; set; }
        public string Specialty { get; set; }
        public string Phone { get; set; }

        [ForeignKey("Clinics")]
        public int ClinicId { get; set; }
        public Clinics? Clinics { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; } = new HashSet<Appointment>();
        public virtual Schedule? Schedule { get; set; }

    }
}
