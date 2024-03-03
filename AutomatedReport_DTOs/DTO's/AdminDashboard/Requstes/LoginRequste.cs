using System.ComponentModel.DataAnnotations;

namespace AutomatedReport_DTOs.AdminDashboard.Requstes
{
    public class LoginRequste
    {
        [Required(ErrorMessage = "User Type Filed Is Required")]
        public string UserType { get; set; }
        [Required(ErrorMessage = "Password Filed Is Required")]
        public string Password { get; set; }
    }
}
