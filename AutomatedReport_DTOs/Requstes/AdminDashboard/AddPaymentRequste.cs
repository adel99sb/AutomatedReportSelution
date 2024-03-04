using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
