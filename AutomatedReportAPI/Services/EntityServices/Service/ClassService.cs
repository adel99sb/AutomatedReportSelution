using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.Requstes.AdminDashboard;
using AutomatedReportCore.Responces;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class ClassService : IClassService<GeneralResponse>
    {
        public Task<GeneralResponse> AddClass(AddClassRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> DeleteClass(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> EditeClass(EditeClassRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> GetAllClasses()
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> GetClassById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
