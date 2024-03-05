using AutomatedReportCore.Responces.DTOs;

namespace AutomatedReportCore.Responces.AdminDashboard
{
    public class GetAllDaysResponse
    {
        public List<DayDto> Days { get; set; } = new();
    }
}