using System.ComponentModel.DataAnnotations;

namespace AutomatedReportAPI.AppData.Models
{
    public class Attendance
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Enter_Time { get; set; }
        public string Outer_Time { get; set; }
        public Student Student { get; set; }
        public DailySessions_Record DailySessions_Record { get; set; }
    }
}
