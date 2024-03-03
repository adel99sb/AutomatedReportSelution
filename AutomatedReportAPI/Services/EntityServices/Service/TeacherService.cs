using AutomatedReport_DTOs;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.DTO_s.AdminDashboard.Requstes;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class TeacherService : ITeacherService<IGeneralResponse>
    {
        public Task<IGeneralResponse> AddTeacher(AddTeacherRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> DeleteTeacher(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> EditeTeacher(EditeTeacherRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> GetAllTeachers()
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> GetTeacherById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
