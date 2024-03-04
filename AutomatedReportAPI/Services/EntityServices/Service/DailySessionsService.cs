using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.Requstes.AdminDashboard;
using AutomatedReportCore.Responces;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class DailySessionsService : IDailySessionsService<GeneralResponse>
    {
        public Task<GeneralResponse> AddDailySessions(AddDailySessionsRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> GetAllDailySessions(Guid divissionId)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> GetAllDailySessionsByDate(GetAllDailySessionsByDateRequste requste)
        {
            throw new NotImplementedException();
        }
    }
}
