using AutomatedReportCore.Responces.DTOs;

namespace AutomatedReportCore.Responces.AdminDashboard
{
    public class GetUsersResponse : GeneralResponse
    {
        public GetUsersResponse(List<UserDto> users) : base(users) { }
    }
}
