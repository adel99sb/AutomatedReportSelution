using AutomatedReport_DTOs;
using AutomatedReport_DTOs.AdminDashboard.Requstes;
using AutomatedReportAPI.Infrastructure.Contracts;
using AutomatedReportAPI.Services;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AutomatedReportAPI.Controllers.AdminDashboard
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class DivisionController : ControllerBase ,IDivisionService<IActionResult>
    {
        private readonly IDivisionService<IGeneralResponse> divisionService;
        public DivisionController(IDivisionService<IGeneralResponse> divisionService)
        {
            this.divisionService = divisionService;            
        }
        [HttpPost("AddDivision")]
        public async Task<IActionResult> AddDivision([Required][FromBody] AddDivisionRequste requste)
        {
            try
            {
                var Result = await divisionService.AddDivision(requste);
                var Response = Result.StatusCode.ToActionResult(Result);
                return Response;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("DeleteDivisione")]
        public async Task<IActionResult> DeleteDivisione([Required][FromQuery] Guid id)
        {
            try
            {
                var Result = await divisionService.DeleteDivisione(id);
                var Response = Result.StatusCode.ToActionResult(Result);
                return Response;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("EditeDivision")]
        public async Task<IActionResult> EditeDivision([Required][FromBody] EditeDivisionRequste requste)
        {
            try
            {
                var Result = await divisionService.EditeDivision(requste);
                var Response = Result.StatusCode.ToActionResult(Result);
                return Response;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetAllDivisiones")]
        public async Task<IActionResult> GetAllDivisiones()
        {
            try
            {
                var Result = await divisionService.GetAllDivisiones();
                var Response = Result.StatusCode.ToActionResult(Result);
                return Response;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetDivisioneById")]
        public async Task<IActionResult> GetDivisioneById([Required][FromQuery] Guid id)
        {
            try
            {
                var Result = await divisionService.GetDivisioneById(id);
                var Response = Result.StatusCode.ToActionResult(Result);
                return Response;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetDivisionsByCertificateName")]
        public async Task<IActionResult> GetDivisionsByCertificateName([Required][FromQuery] string certificateName)
        {
            try
            {
                var Result = await divisionService.GetDivisionsByCertificateName(certificateName);
                var Response = Result.StatusCode.ToActionResult(Result);
                return Response;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
