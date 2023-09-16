using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic.DAL
{
    public class DOW
    {
        [Key]
        public int DayOfWeek_ID { get; set; }

        [ForeignKey("Schedual")]
        public int ScheduleId { get; set; }
        public Schedule? Schedule { get; set; }
        public string Day { get; set; }

        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }
        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }
    }
}
