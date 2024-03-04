﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AutomatedReportCore.Requstes.AdminDashboard
{
    public class AddSessionRequste
    {
        [Required(ErrorMessage = "Division Id Filed Is Required")]
        public Guid DivisionId { get; set; }
        [Required(ErrorMessage = "Class Id Filed Is Required")]
        public Guid _ClassId { get; set; }
        [Required(ErrorMessage = "Subject Id Filed Is Required")]
        public Guid SubjectId { get; set; }
        [Required(ErrorMessage = "day Filed Is Required")]
        public DayOfWeek day { get; set; }
        [Required(ErrorMessage = "Hall Id Filed Is Required")]
        public Guid HallId { get; set; }
    }
}
