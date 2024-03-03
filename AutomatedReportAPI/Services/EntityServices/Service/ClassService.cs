using AutomatedReport_DTOs;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.DTO_s.AdminDashboard.Requstes;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class ClassService : IClassService<IGeneralResponse>
    {
        public Task<IGeneralResponse> AddClass(AddClassRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> DeleteClass(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> EditeClass(EditeClassRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> GetAllClasses()
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> GetClassById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
