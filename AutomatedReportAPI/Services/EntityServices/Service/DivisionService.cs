using AutomatedReport_Core.DTO_s.AdminDashboard.Responces;
using AutomatedReport_DTOs;
using AutomatedReport_DTOs.AdminDashboard.Requstes;
using AutomatedReportAPI.AppData.Models;
using AutomatedReportAPI.Infrastructure.Contracts;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.DTO_s.AdminDashboard.Models;
using AutomatedReportCore.Enums;
using Microsoft.EntityFrameworkCore;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class DivisionService : IDivisionService<IGeneralResponse>
    {
        private readonly IDivisionRepository divisionRepository;
        private readonly ICertificateRepository certificateRepository;
        public DivisionService(IDivisionRepository divisionRepository,
            ICertificateRepository certificateRepository)
        {
            this.divisionRepository = divisionRepository;
            this.certificateRepository = certificateRepository;
        }

        public Task<IGeneralResponse> AddDivision(AddDivisionRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> DeleteDivision(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> EditeDivision(EditeDivisionRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> GetAllDivisions(Guid? certificateId)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> GetAllDivisionsWithStudentsNomber(Guid certificateId)
        {
            throw new NotImplementedException();
        }

        public Task<IGeneralResponse> GetDivisionById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
