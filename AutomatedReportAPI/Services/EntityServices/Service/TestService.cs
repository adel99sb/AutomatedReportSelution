using AutomatedReport_DTOs;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.DTO_s.AdminDashboard.Requstes;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class TestService : ITestService<IGeneralResponse>
    {
        public Task<IGeneralResponse> AddTest(AddTestRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> DeleteTest(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> EditeTest(EditeTestRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> GetAllTests(Guid divisionId)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> GetTestById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> MarkAsDone(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
