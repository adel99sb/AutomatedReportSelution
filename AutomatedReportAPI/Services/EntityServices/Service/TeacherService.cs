using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.Requstes.AdminDashboard;
using AutomatedReportCore.Responces;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class TeacherService : ITeacherService<GeneralResponse>
    {
        public Task<GeneralResponse> AddTeacher(AddTeacherRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> DeleteTeacher(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> EditeTeacher(EditeTeacherRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> GetAllTeachers()
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> GetTeacherById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
