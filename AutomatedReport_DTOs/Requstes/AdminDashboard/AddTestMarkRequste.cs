using AutomatedReportCore.Requstes.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedReportCore.Requstes.AdminDashboard
{
    public class AddTestMarkRequste
    {
        [Required(ErrorMessage = "Test Marks List Filed Is Required")]
        public List<TestMarkDto> TestMarksList { get; set; }
    }
}
