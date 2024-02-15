using AutomatedReport_DTOs;
using AutomatedReportCore.DTO_s.AdminDashboard.Models;

namespace AutomatedReport_Core.DTO_s.AdminDashboard.Responces
{
    public class GetAllCertificatesResponse : GeneralResponse
    {
        public GetAllCertificatesResponse(List<CertificateDto> certificates) : base(certificates) { }
    }
}
