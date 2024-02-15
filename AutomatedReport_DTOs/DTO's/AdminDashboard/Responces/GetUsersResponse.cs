using AutomatedReport_DTOs;

namespace AutomatedReport_Core.DTO_s.AdminDashboard.Responces
{
    public class GetUsersResponse : GeneralResponse
    {
        public GetUsersResponse(List<UsersDto> users) : base(users) { }
    }
}
