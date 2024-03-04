using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.Requstes.AdminDashboard;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AutomatedReportAPI.Controllers.AdminDashboard
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class PaymentController : ControllerBase, IPaymentService<IActionResult>
    {
        [HttpPost("AddPayment")]
        public Task<IActionResult> AddPayment([Required,FromBody] AddPaymentRequste requste)
        {
            throw new NotImplementedException();
        }
        [HttpGet("GetAllPayments")]
        public Task<IActionResult> GetAllPayments([Required,FromQuery] Guid studentId)
        {
            throw new NotImplementedException();
        }
    }
}
