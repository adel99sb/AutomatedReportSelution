using AutomatedReportCore.Responces.DTOs;

namespace AutomatedReportCore.Responces.AdminDashboard
{
    public class GetAllDivisionesResponse : GeneralResponse
    {
        public GetAllDivisionesResponse(List<DivisionDto> divisions) : base(divisions) { }
    }
}
