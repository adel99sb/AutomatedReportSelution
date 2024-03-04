using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedReportCore.Requstes.AdminDashboard
{
    public class AddClassRequste
    {
        [Required(ErrorMessage = "Name Filed Is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "From Time Filed Is Required")]
        public string From_Time { get; set; }
        [Required(ErrorMessage = "To Time Filed Is Required")]
        public string To_Time { get; set; }
    }
}
