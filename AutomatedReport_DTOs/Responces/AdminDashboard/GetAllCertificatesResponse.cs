using AutomatedReportCore.Responces.DTOs;

namespace AutomatedReportCore.Responces.AdminDashboard
{
    public class GetAllCertificatesResponse
    {
        public GetAllCertificatesResponse(List<asda> certificates, bool isDone)
        {
            Certificates = certificates;
            IsDone = isDone;
        }

        public List<asda> Certificates { get; }
        public bool IsDone { get; }
    }
    public class asda : CertificateDto
    {
        public int Test { get; set; }
    }
}
