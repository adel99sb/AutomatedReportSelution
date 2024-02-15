using AutomatedReport_Core.DTO_s.AdminDashboard.Responces;
using AutomatedReport_DTOs;
using AutomatedReport_DTOs.AdminDashboard.Requstes;
using AutomatedReportAPI.AppData.Models;
using AutomatedReportAPI.Infrastructure.Contracts;
using AutomatedReportAPI.Services;
using AutomatedReportCore.DTO_s.AdminDashboard.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AutomatedReportAPI.Controllers.AdminDashboard
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class DivisionController : ControllerBase
    {
        private readonly IDivisionRepository divisionRepository;
        private readonly ICertificateRepository certificateRepository;
        public DivisionController(IDivisionRepository divisionRepository, ICertificateRepository certificateRepository)
        {
            this.divisionRepository = divisionRepository;
            this.certificateRepository = certificateRepository;
        }
        [HttpPost("AddDivision")]
        public async Task<IActionResult> AddDivision([FromBody] AddDivisionRequste requste)
        {
            var certificate = await certificateRepository.GetById(requste.CertificateId);
            GeneralResponse response = new GeneralResponse(null);

            if (certificate != null)
            {
                var NewDivision = new Division()
                {
                    Name = requste.Name,
                    Certificate = certificate
                };

                await divisionRepository.Create(NewDivision);

                response.Message = "Division Added Succesfully";
                return Ok(response);
            }
            else
            {
                response.Message = "Certificate Not Found !!";
                return BadRequest(response);
            }
        }
        [HttpPut("EditeDivision")]
        public async Task<IActionResult> EditeDivision([FromBody] EditeDivisionRequste requste)
        {
            var certificate = await certificateRepository.GetById(requste.CertificateId);
            var division = await divisionRepository.GetById(requste.Id);
            GeneralResponse response = new GeneralResponse(null);

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

                    response.Message = "Division Edited Succesfully";
                    return Ok(response);
                }
                else
                {
                    response.Message = "Certificate Not Found !!";
                    return BadRequest(response);
                }
            }
            else
            {
                response.Message = "Division Not Found !!";
                return BadRequest(response);
            }
        }
        [HttpGet("GetAllDivisiones")]
        public async Task<IActionResult> GetAllDivisiones()
        {
            var Divisionses = divisionRepository.GetAll().Include(c => c.Certificate);
            var DivisionsesDtos = new List<DivisionDto>();
            GetAllDivisionesResponse response;

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
                response.Message = "Get Divisiones Succesfully";
                return Ok(response);
            }
            else
            {
                response = new GetAllDivisionesResponse(null);
                response.Message = "No Divisiones Found";
                return BadRequest(response);
            }
        }
        [HttpDelete("DeleteDivisione")]
        public async Task<IActionResult> DeleteDivisione([FromQuery][Required] Guid Id)
        {
            var division = await divisionRepository.GetById(Id);
            GeneralResponse response = new GeneralResponse(null);

            if (division != null)
            {
                await divisionRepository.Delete(Id);

                response.Message = "Division Deleted Succesfully";
                return Ok(response);
            }
            else
            {
                response.Message = "Division Not Found !!";
                return BadRequest(response);
            }
        }
        [HttpGet("GetDivisioneById")]
        public async Task<IActionResult> GetDivisioneById([FromQuery][Required] Guid Id)
        {            
            var divisionDtos = new DivisionDto();
            GetDivisioneByIdResponse response;

            try
            {
                var division = divisionRepository.GetAll().Where(d => d.Id == Id)
                .Include(c => c.Certificate).First();
                if (division != null)
                {
                    divisionDtos.Id = division.Id;
                    divisionDtos.Name = division.Name;
                    divisionDtos.CertificateName = division.Certificate.Name;

                    response = new GetDivisioneByIdResponse(divisionDtos);
                    response.Message = "Get Division Succesfully";
                    return Ok(response);
                }                
            }
            catch (Exception)
            {
                response = new GetDivisioneByIdResponse(null);
                response.Message = "No Division Found";
                return BadRequest(response);
            }
            return BadRequest();
        }
    }
}
