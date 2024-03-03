using AutomatedReport_DTOs;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.DTO_s.AdminDashboard.Requstes;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class StudentService : IStudentService<IGeneralResponse>
    {
        public Task<IGeneralResponse> AddStudent(AddStudentRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> DeleteStudent(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> EditeStudent(EditeStudentRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> GetAllStudentsByDivisionId(Guid divisionId)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> GetAllStudentsByTestId(Guid testId)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> GetAllStudentsWithDivision()
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> GetStudentById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
