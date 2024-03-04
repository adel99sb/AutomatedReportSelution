using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.Requstes.AdminDashboard;
using AutomatedReportCore.Responces;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class PaymentService : IPaymentService<GeneralResponse>
    {
        public Task<GeneralResponse> AddPayment(AddPaymentRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> GetAllPayments(Guid studentId)
        {
            throw new NotImplementedException();
        }
    }
}
