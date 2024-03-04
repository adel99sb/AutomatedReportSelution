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
    public class Sessions_RecordController : ControllerBase, ISessions_RecordService<IActionResult>
    {
        [HttpPost("AddSession")]
        public Task<IActionResult> AddSession([Required,FromBody] AddSessionRequste requste)
        {
            throw new NotImplementedException();
        }
        [HttpDelete("DeleteSession")]
        public Task<IActionResult> DeleteSession([Required,FromQuery] Guid id)
        {
            throw new NotImplementedException();
        }
        [HttpPut("EditeSession")]
        public Task<IActionResult> EditeSession([Required,FromBody] EditeSessionRequste requste)
        {
            throw new NotImplementedException();
        }
        [HttpGet("GetAllDays")]
        public Task<IActionResult> GetAllDays()
        {
            throw new NotImplementedException();
        }
        [HttpGet("GetAllSessions")]
        public Task<IActionResult> GetAllSessions([Required,FromQuery] Guid divisionId)
        {
            throw new NotImplementedException();
        }
        [HttpGet("GetAllSessionsByDay")]
        public Task<IActionResult> GetAllSessionsByDay([Required,FromQuery] GetAllSessionsByDayRequste requste)
        {
            throw new NotImplementedException();
        }
        [HttpGet("GetAllSessionsGroupedByDays")]
        public Task<IActionResult> GetAllSessionsGroupedByDays([Required, FromQuery] Guid divisionId)
        {
            throw new NotImplementedException();
        }
    }
}
