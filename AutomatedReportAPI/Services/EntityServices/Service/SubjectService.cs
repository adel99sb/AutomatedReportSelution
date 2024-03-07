using AutomatedReportAPI.Infrastructure.Contracts;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.Responces;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class SubjectService : ISubjectService<GeneralResponse>
    {
        private readonly ISubjectRepository subjectRepository;
        private readonly ICertificateRepository certificateRepository;
        public SubjectService(ISubjectRepository subjectRepository,
            ICertificateRepository certificateRepository)
        {
            this.subjectRepository = subjectRepository;
            this.certificateRepository = certificateRepository;
        }

        public Task<GeneralResponse> GetAllSubjects(Guid divisionId)
        {
            throw new NotImplementedException();
        }
    }
}
