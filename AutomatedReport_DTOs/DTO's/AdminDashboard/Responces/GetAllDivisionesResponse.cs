using AutomatedReport_DTOs;
using AutomatedReportCore.DTO_s.AdminDashboard.Models;

namespace AutomatedReport_Core.DTO_s.AdminDashboard.Responces
{
    public class GetAllDivisionesResponse : GeneralResponse
    {
        public GetAllDivisionesResponse(List<DivisionDto> divisions) : base(divisions) { }
    }
}
