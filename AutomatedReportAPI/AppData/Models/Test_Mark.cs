using System.ComponentModel.DataAnnotations;

namespace AutomatedReportAPI.AppData.Models
{
    public class Test_Mark
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [Range(0,3000)]
        public double Mark { get; set; }
        public Test Test { get; set; }
        public Student Student { get; set; }
    }
}
