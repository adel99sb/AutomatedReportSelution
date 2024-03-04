using System.ComponentModel.DataAnnotations;

namespace AutomatedReportCore.Requstes.AdminDashboard
{
    public class AddStudentRequste
    {
        [Required(ErrorMessage = "First Name Filed Is Required")]
        public string First_Name { get; set; }
        [Required(ErrorMessage = "Last Name Filed Is Required")]
        public string Last_Name { get; set; }
        [Required(ErrorMessage = "Gender Filed Is Required")]
        public string Gender { get; set; }
        public string? Address { get; set; }
        [Required(ErrorMessage = "Birth Day Filed Is Required")]
        public DateTime BirthDay { get; set; }
        [Required(ErrorMessage = "Phone Filed Is Required")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Parent Name Filed Is Required")]
        public string Parent_Name { get; set; }
        [Required(ErrorMessage = "Parent Phone Filed Is Required")]
        public string Parent_Phone { get; set; }
        [Required(ErrorMessage = "Total Payments Filed Is Required")]
        [Range(0, double.MaxValue, ErrorMessage = "Total Payments Filed can not be a negative value")]
        public double Total_Payments { get; set; }
        [Required(ErrorMessage = "Division Id Filed Is Required")]
        public Guid DivisionId { get; set; }
    }
}
