using AutomatedReportCore.Responces.DTOs;

namespace AutomatedReportCore.Responces.AdminDashboard
{
    public class GetAllSessionsResponse
    {
        public List<SessionDto> Sessions { get; set; } = new();
    }
}