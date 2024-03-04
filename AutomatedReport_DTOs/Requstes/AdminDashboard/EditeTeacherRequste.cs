using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedReportCore.Requstes.AdminDashboard
{
    public class EditeTeacherRequste : AddTeacherRequste
    {
        [Required(ErrorMessage = "Teacher Id Filed Is Required")]
        public Guid Id { get; set; }
    }
}
