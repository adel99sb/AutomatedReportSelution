using System.ComponentModel.DataAnnotations;

namespace AutomatedReportCore.Requstes.AdminDashboard
{
    public class AddDivisionRequste
    {
        [Required(ErrorMessage = "Division Name Filed Is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Certificate Id Filed Is Required")]
        public Guid CertificateId { get; set; }
    }
}
