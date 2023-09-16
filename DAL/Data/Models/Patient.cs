using System.ComponentModel.DataAnnotations;

namespace Clinic.DAL
{
    public class Patient
    {

        [Key]
        public int PatientId { get; set; }
        [Required]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; } = new HashSet<Appointment>();

    }
}
