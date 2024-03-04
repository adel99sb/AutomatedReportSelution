using AutomatedReportAPI.AppData.Models;
using AutomatedReportAPI.Infrastructure.Contracts;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.Enums;
using AutomatedReportCore.Requstes.AdminDashboard;
using AutomatedReportCore.Responces;
using Microsoft.EntityFrameworkCore;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class DivisionService : IDivisionService<GeneralResponse>
    {
        private readonly IDivisionRepository divisionRepository;
        private readonly ICertificateRepository certificateRepository;
        public DivisionService(IDivisionRepository divisionRepository,
            ICertificateRepository certificateRepository)
        {
            this.divisionRepository = divisionRepository;
            this.certificateRepository = certificateRepository;
        }

        public Task<GeneralResponse> AddDivision(AddDivisionRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> DeleteDivision(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> EditeDivision(EditeDivisionRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> GetAllDivisions(Guid? certificateId)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> GetAllDivisionsWithStudentsNomber(Guid certificateId)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> GetDivisionById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
