using AutomatedReportCore.Responces.DTOs;

namespace AutomatedReportCore.Responces.AdminDashboard
{
    public class GetAllSubjectsResponse : GeneralResponse
    {
        public GetAllSubjectsResponse(List<SubjectDto> subjects) : base(subjects) { }
    }
}
