using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.Requstes.AdminDashboard;
using AutomatedReportCore.Responces;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class TestService : ITestService<GeneralResponse>
    {
        public Task<GeneralResponse> AddTest(AddTestRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> DeleteTest(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> EditeTest(EditeTestRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> GetAllTests(Guid divisionId)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> GetTestById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> MarkAsDone(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
