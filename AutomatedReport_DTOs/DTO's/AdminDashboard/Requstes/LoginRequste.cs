using AutomatedReport_Core;
using AutomatedReportAPI.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedReport_DTOs.AdminDashboard.Requstes
{
    public class LoginRequste
    {
        [Required(ErrorMessage = "User Type Filed Is Required")]
        public string UserType { get; set; }
        [Required(ErrorMessage = "Password Filed Is Required")]
        [PasswordPropertyText]
        public string Password { get; set; }
    }
}
