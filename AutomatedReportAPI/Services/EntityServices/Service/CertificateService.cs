using AutomatedReport_Core.DTO_s.AdminDashboard.Responces;
using AutomatedReport_DTOs;
using AutomatedReportAPI.Infrastructure.Contracts;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.DTO_s.AdminDashboard.Models;
using AutomatedReportCore.Enums;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class CertificateService : ICertificateService<IGeneralResponse>
    {
        private readonly ICertificateRepository certificateRepository;
        public CertificateService(ICertificateRepository certificateRepository)
        {
            this.certificateRepository = certificateRepository;
        }
        public async Task<IGeneralResponse> GetAllCertificates()
        {
            var certificatesDto = new List<CertificateDto>();
            IGeneralResponse response;
            try
            {
                var Certificates = certificateRepository.GetAll();
                foreach (var certificate in Certificates)
                {
                    certificatesDto.Add(new CertificateDto()
                    {
                        Id = certificate.Id,
                        Name = certificate.Name
                    });
                }
                if (certificatesDto.Count != 0)
                {
                    response = new GetAllCertificatesResponse(certificatesDto);
                    response.StatusCode = Requests_Status.Ok;
                    response.Message = "Get Certificates Succesfully";
                }
                else
                {
                    response = new GeneralResponse(null);
                    response.StatusCode = Requests_Status.NotFound;
                    response.Message = "No Certificates Found !!";
                }
            }
            catch (Exception ex)
            {
                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.InternalServerError;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
