using AutomatedReportCore.Responces.DTOs;

namespace AutomatedReportCore.Responces.AdminDashboard
{
    public class GetAllSessionsGroupedByDaysResponse
    {
        public Dictionary<DayOfWeek, List<GroupedSessionDto>> DaySessions { get; set; } = new();
    }
}
