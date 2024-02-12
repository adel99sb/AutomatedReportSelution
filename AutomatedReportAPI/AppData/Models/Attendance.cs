using System.ComponentModel.DataAnnotations;

namespace AutomatedReportAPI.AppData.Models
{
    public class Attendance
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public DateTime Date { get; set; }
        public string Enter_Time { get; set; }
        public string Outer_Time { get; set; }
        public Student Student { get; set; }
        public Sessions_Record session { get; set; }
    }
}
