using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.Requstes.AdminDashboard;
using AutomatedReportCore.Responces;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class Sessions_RecordService : ISessions_RecordService<GeneralResponse>
    {
        public Task<GeneralResponse> AddSession(AddSessionRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> DeleteSession(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> EditeSession(EditeSessionRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> GetAllDays()
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> GetAllSessions(Guid divisionId)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> GetAllSessionsByDay(GetAllSessionsByDayRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> GetAllSessionsGroupedByDays(Guid divisionId)
        {
            throw new NotImplementedException();
        }
    }
}
