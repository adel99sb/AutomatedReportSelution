using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.Requstes.AdminDashboard;
using AutomatedReportCore.Responces;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class StudentService : IStudentService<GeneralResponse>
    {
        public Task<GeneralResponse> AddStudent(AddStudentRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> DeleteStudent(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> EditeStudent(EditeStudentRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> GetAllStudentsByDivisionId(Guid divisionId)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> GetAllStudentsByTestId(Guid testId)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> GetAllStudentsWithDivision()
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> GetStudentById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
