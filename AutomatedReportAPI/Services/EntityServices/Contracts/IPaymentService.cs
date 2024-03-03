using AutomatedReportCore.DTO_s.AdminDashboard.Requstes;

namespace AutomatedReportAPI.Services.EntityServices.Contracts
{
    public interface IPaymentService<T>
    {
        Task<T> GetAllPayments(Guid studentId);
        Task<T> AddPayment(AddPaymentRequste requste);
    }
}
