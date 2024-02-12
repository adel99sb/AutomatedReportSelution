using System.ComponentModel.DataAnnotations;

namespace AutomatedReportAPI.Enums
{
    public enum ClassTimes
    {
        [Display(Name = "08:30 => 10:00")]
        First = 0,
        [Display(Name = "10:00 => 11:30")]
        Second = 1,
        [Display(Name = "11:30 => 01:00")]
        Therid = 2,
        [Display(Name = "01:00 => 02:30")]
        Fourth = 3,
        [Display(Name = "02:30 => 04:00")]
        Fiveth = 4,
        [Display(Name = "04:00 => 05:30")]
        Sixeth = 5        
    }
    public enum UserTypes
    {
        [Display(Name = "مدير")]
        Manager = 0,
        [Display(Name = "مشرف")]
        Assistante = 0,
    }
}
