using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedReportCore.Requstes.AdminDashboard
{
    public class AddHallRequste
    {
        [Required(ErrorMessage = "Name Filed Is Required")]
        public string Name { get; set; }
    }
}
