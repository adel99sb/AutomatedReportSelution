using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.DTO_s.AdminDashboard.Requstes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AutomatedReportAPI.Controllers.AdminDashboard
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class TestController : ControllerBase, ITestService<IActionResult>
    {
        [HttpPost("AddTest")]
        public Task<IActionResult> AddTest([Required,FromBody] AddTestRequste requste)
        {
            throw new NotImplementedException();
        }
        [HttpDelete("DeleteTest")]
        public Task<IActionResult> DeleteTest([Required,FromQuery] Guid id)
        {
            throw new NotImplementedException();
        }
        [HttpPut("EditeTest")]
        public Task<IActionResult> EditeTest([Required,FromBody] EditeTestRequste requste)
        {
            throw new NotImplementedException();
        }
        [HttpGet("GetAllTests")]
        public Task<IActionResult> GetAllTests([Required,FromQuery] Guid divisionId)
        {
            throw new NotImplementedException();
        }
        [HttpGet("GetTestById")]
        public Task<IActionResult> GetTestById([Required,FromQuery] Guid id)
        {
            throw new NotImplementedException();
        }
        [HttpPut("MarkAsDone")]
        public Task<IActionResult> MarkAsDone([Required, FromQuery] Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
