using System.ComponentModel.DataAnnotations;

namespace AutomatedReport_DTOs.AdminDashboard.Requstes
{
    public class EditeDivisionRequste : AddDivisionRequste
    {
        [Required(ErrorMessage = "Division Id Filed Is Required")]
        public Guid Id { get; set; }
    }
}
