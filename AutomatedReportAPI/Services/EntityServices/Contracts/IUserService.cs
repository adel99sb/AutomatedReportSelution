using AutomatedReport_DTOs.AdminDashboard.Requstes;

namespace AutomatedReportAPI.Services.EntityServices.Contracts
{
    public interface IUserService<T>
    {
        Task<T> Login(LoginRequste request);
        Task<T> GetUsers();
        Task<T> EditeUserPassword(EditeUserPasswordRequste request);
    }
}
