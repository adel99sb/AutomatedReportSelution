using AutomatedReport_Core.DTO_s.AdminDashboard.Responces;
using AutomatedReportAPI.Infrastructure.Contracts;
using AutomatedReportAPI.Infrastructure.Repositories;
using AutomatedReportCore.DTO_s.AdminDashboard.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutomatedReportAPI.Controllers.AdminDashboard
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class CertificateController : ControllerBase
    {
        private readonly ICertificateRepository certificateRepository;
        public CertificateController(ICertificateRepository certificateRepository)
        {
            this.certificateRepository = certificateRepository;
        }
        [HttpGet("GetAllCertificates")]
        public async Task<IActionResult> GetAllCertificates()
        {
            var Certificates = certificateRepository.GetAll();
            var certificatesDto = new List<CertificateDto>();
            GetAllCertificatesResponse response;

            foreach (var certificate in Certificates)
            {
                certificatesDto.Add(new CertificateDto()
                {
                    Id = certificate.Id,
                    Name = certificate.Name
                });
            }
            response = new GetAllCertificatesResponse(certificatesDto);
            response.Message = "Get Certificates Succesfully";
            return Ok(response);
        }
    }
}
