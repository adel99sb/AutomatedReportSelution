using AutomatedReportAPI.Infrastructure.Contracts;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.Enums;
using AutomatedReportCore.Responces;
using AutomatedReportCore.Responces.AdminDashboard;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class CertificateService : ICertificateService<GeneralResponse>
    {
        private readonly ICertificateRepository certificateRepository;
        public CertificateService(ICertificateRepository certificateRepository)
        {
            this.certificateRepository = certificateRepository;
        }
        public async Task<GeneralResponse> GetAllCertificates()
        {
            var certificatesDto = new List<asda>();
            GeneralResponse response;
            try
            {
                var Certificates = certificateRepository.GetAll();
                foreach (var certificate in Certificates)
                {
                    certificatesDto.Add(new asda()
                    {
                        Id = certificate.Id,
                        Name = certificate.Name,
                        Test = 5
                    });
                }
                if (certificatesDto.Count != 0)
                {
                    var data = new GetAllCertificatesResponse(certificatesDto,true);

                    response = new GeneralResponse(data);
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
