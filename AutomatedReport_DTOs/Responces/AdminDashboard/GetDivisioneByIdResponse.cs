using AutomatedReportCore.Responces.DTOs;

namespace AutomatedReportCore.Responces.AdminDashboard
{
    public class GetDivisioneByIdResponse : GeneralResponse
    {
        public GetDivisioneByIdResponse(DivisionDto division) : base(division) { }
    }
}
