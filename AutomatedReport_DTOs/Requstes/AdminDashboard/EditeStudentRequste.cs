using System.ComponentModel.DataAnnotations;

namespace AutomatedReportCore.Requstes.AdminDashboard
{
    public class EditeStudentRequste : AddStudentRequste
    {
        [Required(ErrorMessage = "Student Id Filed Is Required")]
        public Guid Id { get; set; }
    }
}
