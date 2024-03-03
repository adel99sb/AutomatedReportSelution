using AutomatedReport_DTOs;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.DTO_s.AdminDashboard.Requstes;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class DailySessionsService : IDailySessionsService<IGeneralResponse>
    {
        public Task<IGeneralResponse> AddDailySessions(AddDailySessionsRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> GetAllDailySessions(Guid divissionId)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> GetAllDailySessionsByDate(GetAllDailySessionsByDateRequste requste)
        {
            throw new NotImplementedException();
        }
    }
}
