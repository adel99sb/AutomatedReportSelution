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

        public async Task<IGeneralResponse> AddDivision(AddDivisionRequste requste)
        {
            IGeneralResponse response;
            try
            {
                var certificate = await certificateRepository.GetById(requste.CertificateId);
                if (certificate != null)
                {
                    var NewDivision = new Division()
                    {
                        Name = requste.Name,
                        Certificate = certificate
                    };

                    await divisionRepository.Create(NewDivision);

                    response = new GeneralResponse(null);
                    response.StatusCode = Requests_Status.Ok;
                    response.Message = "Division Add Successfully";
                }
                else
                {
                    response = new GeneralResponse(null);
                    response.StatusCode = Requests_Status.NotFound;
                    response.Message = "Certificate Not Found !!";
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

        public async Task<IGeneralResponse> DeleteDivisione(Guid id)
        {
            IGeneralResponse response;
            try
            {
                var division = await divisionRepository.GetById(id);
                if (division != null)
                {
                    await divisionRepository.Delete(id);

                    response = new GeneralResponse (null);
                    response.StatusCode = Requests_Status.Accepted;
                    response.Message = "Division Deleted Succesfully";
                }
                else
                {
                    response = new GeneralResponse(null);
                    response.StatusCode = Requests_Status.NotFound;
                    response.Message = "Division Not Found !!";
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

        public async Task<IGeneralResponse> EditeDivision(EditeDivisionRequste requste)
        {
            IGeneralResponse response;
            try
            {
                var certificate = await certificateRepository.GetById(requste.CertificateId);
                var division = await divisionRepository.GetById(requste.Id);
                if (division != null)
                {
                    if (certificate != null)
                    {
                        var NewDivision = new Division()
                        {
                            Id = requste.Id,
                            Name = requste.Name,
                            Certificate = certificate
                        };

                        await divisionRepository.Update(NewDivision);

                        response = new GeneralResponse(null);
                        response.StatusCode = Requests_Status.Accepted;
                        response.Message = "Division Edited Succesfully";
                    }
                    else
                    {
                        response = new GeneralResponse(null);
                        response.StatusCode = Requests_Status.NotFound;
                        response.Message = "Certificate Not Found !!";
                    }
                }
                else
                {
                    response = new GeneralResponse(null);
                    response.StatusCode = Requests_Status.NotFound;
                    response.Message = "Division Not Found !!";
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
        public async Task<IGeneralResponse> GetAllDivisiones()
        {
            var DivisionsesDtos = new List<DivisionDto>();
            IGeneralResponse response;
            try
            {
                var Divisionses = divisionRepository.GetAll().Include(c => c.Certificate);                
                if (Divisionses.Count() != 0)
                {
                    foreach (var Division in Divisionses)
                    {
                        DivisionsesDtos.Add(new DivisionDto()
                        {
                            Id = Division.Id,
                            Name = Division.Name,
                            CertificateName = Division.Certificate.Name
                        });
                    }

                    response = new GetAllDivisionesResponse(DivisionsesDtos);
                    response.StatusCode = Requests_Status.Ok;
                    response.Message = "Get Divisiones Succesfully";
                }
                else
                {
                    response = new GeneralResponse(null);
                    response.StatusCode = Requests_Status.NotFound;
                    response.Message = "No Divisiones Found";
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

        public async Task<IGeneralResponse> GetDivisioneById(Guid id)
        {
            var divisionDtos = new DivisionDto();
            IGeneralResponse response;
            try
            {
                var division = divisionRepository.GetAll().Where(d => d.Id == id)
                    .Include(c => c.Certificate).First();
                if (division != null)
                {
                    divisionDtos.Id = division.Id;
                    divisionDtos.Name = division.Name;
                    divisionDtos.CertificateName = division.Certificate.Name;

                    response = new GetDivisioneByIdResponse(divisionDtos);
                    response.StatusCode = Requests_Status.Ok;
                    response.Message = "Get Division Succesfully";
                }
                else
                {
                    response = new GeneralResponse(null);
                    response.StatusCode = Requests_Status.NotFound;
                    response.Message = "No Division Found";
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
        public async Task<IGeneralResponse> GetDivisionsByCertificateName(string CertificateName)
        {
            List<DivisionDto> divisionsDto = new List<DivisionDto>();
            IGeneralResponse response;
            try
            {
                var divisions = divisionRepository.GetAll();
                if (!string.IsNullOrEmpty(CertificateName))
                {
                    divisions.Include(c => c.Certificate)
                    .Where(c => c.Certificate.Name == CertificateName);
                    
                    foreach (var item in divisions)
                    {
                        divisionsDto.Add(new DivisionDto()
                        {
                            Name = item.Name,
                            Id = item.Id,
                            CertificateName = item.Certificate.Name
                        });
                    }
                    if (divisionsDto.Count != 0)
                    {
                        response = new GetAllDivisionesResponse(divisionsDto);
                        response.StatusCode = Requests_Status.Ok;
                        response.Message = $"Get {CertificateName} Divisiones Succesfully";
                    }
                    else
                    {
                        response = new GeneralResponse(null);
                        response.StatusCode = Requests_Status.NotFound;
                        response.Message = $"NO Divisiones Found With {CertificateName}!!";
                    }
                }
                else
                {
                    response = new GeneralResponse(null);
                    response.StatusCode = Requests_Status.BadRequest;
                    response.Message = "No Certificate Name Choosen !!";
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
