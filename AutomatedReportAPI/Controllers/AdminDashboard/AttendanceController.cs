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
    public class AttendanceController : ControllerBase, IAttendanceService<IActionResult>
    {
        [HttpPost("AddAttendance")]
        public Task<IActionResult> AddAttendance([Required,FromBody] AddAttendanceRequste requste)
        {
            throw new NotImplementedException();
        }
    }
}
