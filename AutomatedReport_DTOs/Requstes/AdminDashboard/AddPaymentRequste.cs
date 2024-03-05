using System.ComponentModel.DataAnnotations;

namespace AutomatedReportCore.Requstes.AdminDashboard
{
    public class AddPaymentRequste
    {
        [Required(ErrorMessage = "Value Filed Is Required")]
        public double Value { get; set; }
        public string? Description { get; set; }
        [Required(ErrorMessage = "Student Id Filed Is Required")]
        public Guid StudentId { get; set; }
    }
}
