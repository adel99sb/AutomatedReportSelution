using AutomatedReportAPI.AppData.Models;
using AutomatedReportAPI.Infrastructure;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.Enums;
using AutomatedReportCore.Requstes.AdminDashboard;
using AutomatedReportCore.Responces;
using AutomatedReportCore.Responces.AdminDashboard;
using AutomatedReportCore.Responces.DTOs;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class PaymentService : IPaymentService<GeneralResponse>
    {
        private readonly IUnitOfWork<Payment> paymentRepository;
        public PaymentService(IUnitOfWork<Payment> paymentRepository)
        {
            this.paymentRepository = paymentRepository;
        }

        public async Task<GeneralResponse> AddPayment(AddPaymentRequste requste)
        {
            GeneralResponse response;
            try
            {
                var Student = paymentRepository.GetAll()
                    .Where(s => s.Student.Id == requste.StudentId).FirstOrDefault()?.Student;
                await paymentRepository.Create(new Payment()
                {                    
                    Description = requste.Description,
                    Student = Student,
                    Value = requste.Value,
                });

                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.Accepted;
                response.Message = "Payment Added Succesfully";
            }
            catch (Exception ex)
            {

                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.BadRequest;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<GeneralResponse> GetAllPayments(Guid studentId)
        {
            var Data = new GetAllPaymentsResponse();
            GeneralResponse response;
            try
            {
                var Payments = paymentRepository.GetAll();
                if (Payments.Count() != 0)
                {
                    foreach (var item in Payments)
                    {
                        Data.payments.Add(new PaymentDto()
                        {
                            Id = item.Id,
                            CreatedAt = item.CreatedAt,
                            Description = item.Description,
                            Value = item.Value
                        });
                    }
                    response = new GeneralResponse(Data);
                    response.StatusCode = Requests_Status.Ok;
                    response.Message = "Get Payments Succesfully";
                }
                else
                {
                    response = new GeneralResponse(null);
                    response.StatusCode = Requests_Status.NotFound;
                    response.Message = "No Payments Found !!";
                }
            }
            catch (Exception ex)
            {

                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.BadRequest;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
