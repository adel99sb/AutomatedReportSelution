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
    public class StudentController : ControllerBase, IStudentService<IActionResult>
    {
        [HttpPost("AddStudent")]
        public Task<IActionResult> AddStudent([Required,FromBody] AddStudentRequste requste)
        {
            throw new NotImplementedException();
        }
        [HttpDelete("DeleteStudent")]
        public Task<IActionResult> DeleteStudent([Required,FromQuery] Guid id)
        {
            throw new NotImplementedException();
        }
        [HttpPut("EditeStudent")]
        public Task<IActionResult> EditeStudent([Required,FromBody] EditeStudentRequste requste)
        {
            throw new NotImplementedException();
        }
        [HttpGet("GetAllStudentsByDivisionId")]
        public Task<IActionResult> GetAllStudentsByDivisionId([Required,FromQuery] Guid divisionId)
        {
            throw new NotImplementedException();
        }
        [HttpGet("GetAllStudentsByTestId")]
        public Task<IActionResult> GetAllStudentsByTestId([Required,FromQuery] Guid testId)
        {
            throw new NotImplementedException();
        }
        [HttpGet("GetAllStudentsWithDivision")]
        public Task<IActionResult> GetAllStudentsWithDivision()
        {
            throw new NotImplementedException();
        }
        [HttpGet("GetStudentById")]
        public Task<IActionResult> GetStudentById([Required, FromQuery] Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
