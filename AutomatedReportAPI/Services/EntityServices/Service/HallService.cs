using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.Requstes.AdminDashboard;
using AutomatedReportCore.Responces;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class HallService : IHallService<GeneralResponse>
    {
        public Task<GeneralResponse> AddHall(AddHallRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> DeleteHall(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> EditeHall(EditeHallRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> GetAllHalls()
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> GetHallById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
