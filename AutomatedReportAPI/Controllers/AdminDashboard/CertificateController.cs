using AutomatedReport_DTOs;
using AutomatedReportAPI.Infrastructure.Contracts;
using AutomatedReportAPI.Services;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace AutomatedReportAPI.Controllers.AdminDashboard
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class CertificateController : ControllerBase , ICertificateService<IActionResult>
    {
        private readonly ICertificateService<IGeneralResponse> certificateService;
        public CertificateController(ICertificateService<IGeneralResponse> certificateService)
        {
            this.certificateService = certificateService;
        }
        [HttpGet("GetAllCertificates")]
        public async Task<IActionResult> GetAllCertificates()
        {
            try
            {
                var Result = await certificateService.GetAllCertificates();
                var Response = Result.StatusCode.ToActionResult(Result);
                return Response;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
