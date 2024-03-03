using AutomatedReport_Core.DTO_s.AdminDashboard.Responces;
using AutomatedReport_DTOs;
using AutomatedReportAPI.Infrastructure.Contracts;
using AutomatedReportAPI.Infrastructure.Repositories;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.DTO_s.AdminDashboard.Models;
using AutomatedReportCore.DTO_s.AdminDashboard.Responces;
using AutomatedReportCore.Enums;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class SubjectService : ISubjectService<IGeneralResponse>
    {
        private readonly ISubjectRepository subjectRepository;
        private readonly ICertificateRepository certificateRepository;
        public SubjectService(ISubjectRepository subjectRepository,
            ICertificateRepository certificateRepository)
        {
            this.subjectRepository = subjectRepository;
            this.certificateRepository = certificateRepository;
        }

        public Task<IGeneralResponse> GetAllSubjects(Guid divisionId)
        {
            throw new NotImplementedException();
        }
    }
}
