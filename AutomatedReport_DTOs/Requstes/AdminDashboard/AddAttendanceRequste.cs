using AutomatedReportCore.Requstes.DTOs;
using System.ComponentModel.DataAnnotations;

namespace AutomatedReportCore.Requstes.AdminDashboard
{
    public class AddAttendanceRequste
    {
        [Required(ErrorMessage = "Attendances List Filed Is Required")]
        public List<AttendanceDto> AttendancesList { get; set; }
    }
}
