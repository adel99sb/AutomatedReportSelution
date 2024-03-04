using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedReportCore.Requstes.DTOs
{
    public class DailySessionDto
    {
        [Required(ErrorMessage = "Date Filed Is Required")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Sessions Record Id Filed Is Required")]
        public Guid Sessions_RecordId { get; set; }
        [Required(ErrorMessage = "Subject Title Filed Is Required")]
        public string Subject_Title { get; set; }
    }
}
