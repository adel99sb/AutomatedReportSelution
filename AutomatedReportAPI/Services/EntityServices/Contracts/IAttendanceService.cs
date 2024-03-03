using AutomatedReportCore.DTO_s.AdminDashboard.Requstes;

namespace AutomatedReportAPI.Services.EntityServices.Contracts
{
    public interface IAttendanceService<T>
    {
        Task<T> AddAttendance(AddAttendanceRequste requste);
    }
}
