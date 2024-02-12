using System.ComponentModel.DataAnnotations;

namespace AutomatedReportAPI.AppData.Models
{
    public class Sessions_Record
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Division Division { get; set; }
        public _Class _Class { get; set; }
        public Subject Subject { get; set; }
        public DayOfWeek day { get; set; } 
    }    
}
