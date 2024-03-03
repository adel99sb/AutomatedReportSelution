using AutomatedReport_DTOs;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.DTO_s.AdminDashboard.Requstes;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class PaymentService : IPaymentService<IGeneralResponse>
    {
        public Task<IGeneralResponse> AddPayment(AddPaymentRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> GetAllPayments(Guid studentId)
        {
            throw new NotImplementedException();
        }
    }
}
