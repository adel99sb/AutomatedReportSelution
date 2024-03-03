using AutomatedReport_DTOs;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.DTO_s.AdminDashboard.Requstes;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class TestMarkService : ITestMarkService<IGeneralResponse>
    {
        public Task<IGeneralResponse> AddTestMarks(AddTestMarkRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> GetAllTestMarks(Guid testId)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> UpdateTestMarks(UpdateTestMarksRequste requste)
        {
            throw new NotImplementedException();
        }
    }
}
