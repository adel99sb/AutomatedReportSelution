using System.ComponentModel.DataAnnotations;

namespace AutomatedReportCore.Requstes.DTOs
{
    public class AddAttendanceDto
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public bool IsAttend { get; set; }
        [Required(ErrorMessage = "Student Id Filed Is Required")]
        public Guid StudentId { get; set; }
        [Required(ErrorMessage = "Daily Sessions Record Id Filed Is Required")]
        public Guid DailySessions_RecordId { get; set; }
    }
}
