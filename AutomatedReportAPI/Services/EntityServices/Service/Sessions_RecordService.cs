using AutomatedReport_DTOs;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.DTO_s.AdminDashboard.Requstes;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class Sessions_RecordService : ISessions_RecordService<IGeneralResponse>
    {
        public Task<IGeneralResponse> AddSession(AddSessionRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> DeleteSession(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> EditeSession(EditeSessionRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> GetAllDays()
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> GetAllSessions(Guid divisionId)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> GetAllSessionsByDay(GetAllSessionsByDayRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> GetAllSessionsGroupedByDays(Guid divisionId)
        {
            throw new NotImplementedException();
        }
    }
}
