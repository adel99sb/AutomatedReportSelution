using AutomatedReportCore.DTO_s.AdminDashboard.Requstes;

namespace AutomatedReportAPI.Services.EntityServices.Contracts
{
    public interface ITestMarkService<T>
    {
        Task<T> AddTestMarks(AddTestMarkRequste requste);
        Task<T> GetAllTestMarks(Guid testId);
        Task<T> UpdateTestMarks(UpdateTestMarksRequste requste);
    }
}
