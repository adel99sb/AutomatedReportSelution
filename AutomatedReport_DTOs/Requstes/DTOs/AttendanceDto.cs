using System.ComponentModel.DataAnnotations;

namespace AutomatedReportCore.Requstes.DTOs
{
    public class AttendanceDto
    {
        public string? Enter_Time { get; set; }
        public string? Outer_Time { get; set; }
        [Required(ErrorMessage = "Student Id Filed Is Required")]
        public Guid StudentId { get; set; }
        [Required(ErrorMessage = "Daily Sessions Record Id Filed Is Required")]
        public Guid DailySessions_RecordId { get; set; }
    }
}
