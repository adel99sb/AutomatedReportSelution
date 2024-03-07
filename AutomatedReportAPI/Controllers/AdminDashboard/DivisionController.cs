using AutomatedReportAPI.AppData.Models;
using AutomatedReportAPI.Infrastructure.Contracts;
using AutomatedReportAPI.Services;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportAPI.Services.EntityServices.Service;
using AutomatedReportCore.Requstes.AdminDashboard;
using AutomatedReportCore.Responces;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AutomatedReportAPI.Controllers.AdminDashboard
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class DivisionController : ControllerBase, IDivisionService<IActionResult>
    {
        private readonly IDivisionService<GeneralResponse> divisionService;
        public DivisionController(IDivisionService<GeneralResponse> divisionService)
        {
            this.divisionService = divisionService;            
        }
        [HttpPost("AddDivision")]
        public Task<IActionResult> AddDivision([Required,FromBody] AddDivisionRequste requste)
        {
            throw new NotImplementedException();
        }
        [HttpDelete("DeleteDivision")]
        public Task<IActionResult> DeleteDivision([Required,FromQuery] Guid id)
        {
            throw new NotImplementedException();
        }
        [HttpPut("EditeDivision")]
        public Task<IActionResult> EditeDivision([Required, FromBody] EditeDivisionRequste requste)
        {
            throw new NotImplementedException();
        }
        [HttpGet("GetAllDivisions")]
        public async Task<IActionResult> GetAllDivisions([FromQuery]Guid? certificateId)
        {
            try
            {
                var Result = await divisionService.GetAllDivisions(certificateId);
                var Response = Result.StatusCode.ToActionResult(Result);
                return Response;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetAllDivisionsWithStudentsNomber")]
        public async Task<IActionResult> GetAllDivisionsWithStudentsNomber([Required,FromQuery]Guid certificateId)
        {
            try
            {
                var Result = await divisionService.GetAllDivisionsWithStudentsNomber(certificateId);
                var Response = Result.StatusCode.ToActionResult(Result);
                return Response;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetDivisionById")]
        public async Task<IActionResult> GetDivisionById([Required,FromQuery] Guid id)
        {
            try
            {
                var Result = await divisionService.GetDivisionById(id);
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
