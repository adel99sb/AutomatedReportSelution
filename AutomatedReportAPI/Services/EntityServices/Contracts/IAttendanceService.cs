using AutomatedReportCore.Requstes.AdminDashboard;

namespace AutomatedReportAPI.Services.EntityServices.Contracts
{
    public interface IAttendanceService<T>
    {
        Task<T> AddAttendance(AddAttendanceRequste requste);
    }
}
