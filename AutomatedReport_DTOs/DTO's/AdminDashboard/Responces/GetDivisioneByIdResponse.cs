using AutomatedReport_DTOs;
using AutomatedReportCore.DTO_s.AdminDashboard.Models;

namespace AutomatedReport_Core.DTO_s.AdminDashboard.Responces
{
    public class GetDivisioneByIdResponse : GeneralResponse
    {
        public GetDivisioneByIdResponse(DivisionDto division) : base(division) { }
    }
}
