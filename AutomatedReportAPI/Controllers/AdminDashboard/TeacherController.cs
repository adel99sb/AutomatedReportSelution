using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.Requstes.AdminDashboard;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AutomatedReportAPI.Controllers.AdminDashboard
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class TeacherController : ControllerBase, ITeacherService<IActionResult>
    {
        [HttpPost("AddTeacher")]
        public Task<IActionResult> AddTeacher([Required,FromBody] AddTeacherRequste requste)
        {
            throw new NotImplementedException();
        }
        [HttpDelete("DeleteTeacher")]
        public Task<IActionResult> DeleteTeacher([Required, FromQuery] Guid id)
        {
            throw new NotImplementedException();
        }
        [HttpPut("EditeTeacher")]
        public Task<IActionResult> EditeTeacher([Required,FromBody] EditeTeacherRequste requste)
        {
            throw new NotImplementedException();
        }
        [HttpGet("GetAllTeachers")]
        public Task<IActionResult> GetAllTeachers()
        {
            throw new NotImplementedException();
        }
        [HttpGet("GetTeacherById")]
        public Task<IActionResult> GetTeacherById([Required,FromQuery] Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
