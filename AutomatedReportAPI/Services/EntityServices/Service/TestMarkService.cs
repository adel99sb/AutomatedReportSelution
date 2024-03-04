using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.Requstes.AdminDashboard;
using AutomatedReportCore.Responces;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class TestMarkService : ITestMarkService<GeneralResponse>
    {
        public Task<GeneralResponse> AddTestMarks(AddTestMarkRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> GetAllTestMarks(Guid testId)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> UpdateTestMarks(EditeTestMarksRequste requste)
        {
            throw new NotImplementedException();
        }
    }
}
