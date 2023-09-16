using System.ComponentModel.DataAnnotations;

namespace Clinic.DAL
{
    public class Clinics
    {

        [Key]
        public int ClinicId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; } = new HashSet<Doctor>();

    }
}
