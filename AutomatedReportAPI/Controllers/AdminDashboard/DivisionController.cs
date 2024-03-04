using AutomatedReportAPI.Infrastructure.Contracts;
using AutomatedReportAPI.Services;
using AutomatedReportAPI.Services.EntityServices.Contracts;
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
        public Task<IActionResult> GetAllDivisions([FromQuery]Guid? certificateId)
        {
            throw new NotImplementedException();
        }
        [HttpGet("GetAllDivisionsWithStudentsNomber")]
        public Task<IActionResult> GetAllDivisionsWithStudentsNomber([Required,FromQuery]Guid certificateId)
        {
            throw new NotImplementedException();
        }
        [HttpGet("GetDivisionById")]
        public Task<IActionResult> GetDivisionById([Required,FromQuery] Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
