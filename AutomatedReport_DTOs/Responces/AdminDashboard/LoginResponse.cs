using AutomatedReportCore.Responces.DTOs;

namespace AutomatedReportCore.Responces.AdminDashboard
{
    public class LoginResponse : GeneralResponse
    {
        public LoginResponse(UserDto user) : base(user) { }
    }
}
