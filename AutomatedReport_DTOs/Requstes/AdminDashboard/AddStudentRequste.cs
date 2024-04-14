using System.ComponentModel.DataAnnotations;

namespace AutomatedReportCore.Requstes.AdminDashboard
{
    public class AddStudentRequste
    {
        [Required(ErrorMessage = "First Name Filed Is Required")]
        public string first_Name { get; set; }
        [Required(ErrorMessage = "Last Name Filed Is Required")]
        public string last_Name { get; set; }
        [Required(ErrorMessage = "Gender Filed Is Required")]
        public string gender { get; set; }
        public string? address { get; set; }
        [Required(ErrorMessage = "Birth Day Filed Is Required")]
        public DateTime birthDay { get; set; }
        [Required(ErrorMessage = "Phone Filed Is Required")]
        public string phone { get; set; }
        [Required(ErrorMessage = "Parent Name Filed Is Required")]
        public string parent_Name { get; set; }
        [Required(ErrorMessage = "Parent Phone Filed Is Required")]
        public string parent_Phone { get; set; }
        [Required(ErrorMessage = "Total Payments Filed Is Required")]
        [Range(0, double.MaxValue, ErrorMessage = "Total Payments Filed can not be a negative value")]
        public double total_Payments { get; set; }
        [Required(ErrorMessage = "Division Id Filed Is Required")]
        public Guid divisionId { get; set; }
    }
}
