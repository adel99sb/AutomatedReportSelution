using AutomatedReport_DTOs.AdminDashboard.Requstes;
using AutomatedReportAPI.AppData.Models;
using AutomatedReportCore.DTO_s.AdminDashboard.Requstes;

namespace AutomatedReportAPI.Services.EntityServices.Contracts
{
    public interface ISessions_RecordService<T>
    {
        Task<T> GetAllSessionsGroupedByDays(Guid divisionId);
        Task<T> GetAllSessions(Guid divisionId);
        Task<T> GetAllSessionsByDay(GetAllSessionsByDayRequste requste);
        Task<T> GetAllDays();
        Task<T> EditeSession(EditeSessionRequste requste);
        Task<T> DeleteSession(Guid id);
        Task<T> AddSession(AddSessionRequste requste);

    }
}
