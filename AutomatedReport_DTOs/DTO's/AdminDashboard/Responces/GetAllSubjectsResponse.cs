using AutomatedReport_DTOs;
using AutomatedReportCore.DTO_s.AdminDashboard.Models;

namespace AutomatedReportCore.DTO_s.AdminDashboard.Responces
{
    public class GetAllSubjectsResponse : GeneralResponse
    {
        public GetAllSubjectsResponse(List<SubjectDto> subjects) : base(subjects) { }
    }
}
