using System.ComponentModel.DataAnnotations;

namespace AutomatedReportCore.Requstes.AdminDashboard
{
    public class AddTeacherRequste
    {
        [Required(ErrorMessage = "Full Name Filed Is Required")]
        public string Full_Name { get; set; }
        public string? Phone { get; set; }
    }
}
