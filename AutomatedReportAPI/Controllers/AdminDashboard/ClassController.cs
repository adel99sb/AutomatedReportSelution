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
    public class ClassController : ControllerBase, IClassService<IActionResult>
    {
        [HttpPost("AddClass")]
        public Task<IActionResult> AddClass([Required,FromBody]AddClassRequste requste)
        {
            throw new NotImplementedException();
        }
        [HttpDelete("DeleteClass")]
        public Task<IActionResult> DeleteClass([Required,FromQuery] Guid id)
        {
            throw new NotImplementedException();
        }
        [HttpPut("EditeClass")]
        public Task<IActionResult> EditeClass([Required,FromBody] EditeClassRequste requste)
        {
            throw new NotImplementedException();
        }
        [HttpGet("GetAllClasses")]
        public Task<IActionResult> GetAllClasses()
        {
            throw new NotImplementedException();
        }
        [HttpGet("GetClassById")]
        public Task<IActionResult> GetClassById([Required,FromQuery] Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
