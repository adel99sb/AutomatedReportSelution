using System.ComponentModel.DataAnnotations;

namespace AutomatedReport_DTOs.AdminDashboard.Requstes
{
    public class AddDivisionRequste
    {
        [Required(ErrorMessage = "Division Name Filed Is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Certificate Id Filed Is Required")]
        public Guid CertificateId { get; set; }
    }
}
