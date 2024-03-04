using System.ComponentModel.DataAnnotations;

namespace AutomatedReportCore.Requstes.AdminDashboard
{
    public class EditeDivisionRequste : AddDivisionRequste
    {
        [Required(ErrorMessage = "Division Id Filed Is Required")]
        public Guid Id { get; set; }
    }
}
