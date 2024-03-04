using AutomatedReportAPI.Infrastructure.Contracts;
using AutomatedReportAPI.Infrastructure.Repositories;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.Enums;
using AutomatedReportCore.Responces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

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
