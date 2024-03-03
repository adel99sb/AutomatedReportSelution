using AutomatedReport_DTOs;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.DTO_s.AdminDashboard.Requstes;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class HallService : IHallService<IGeneralResponse>
    {
        public Task<IGeneralResponse> AddHall(AddHallRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> DeleteHall(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> EditeHall(EditeHallRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> GetAllHalls()
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> GetHallById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
