using AutomatedReport_DTOs.AdminDashboard.Requstes;

namespace AutomatedReportAPI.Services.EntityServices.Contracts
{
    public interface IUserService<T>
    {
        Task<T> Login(LoginRequste request);
        Task<T> GetAllUsers();
        Task<T> EditeUserPassword(EditeUserPasswordRequste request);
    }
}
