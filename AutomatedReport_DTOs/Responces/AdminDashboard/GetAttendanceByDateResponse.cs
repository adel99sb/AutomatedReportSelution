using AutomatedReportCore.Requstes.DTOs;

namespace AutomatedReportCore.Responces.AdminDashboard
{
    public class GetAttendanceByDateResponse
    {
        public string Time { get; set; }
        public string Subject { get; set; }
        public string SubjectTitle { get; set; }
        public string Hall { get; set; }
        public List<GetAttendanceDto> attendances { get; set; } = new();
    }
}