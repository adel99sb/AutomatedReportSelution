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
    public class DailySessionsController : ControllerBase, IDailySessionsService<IActionResult>
    {
        [HttpPost("AddDailySessions")]
        public Task<IActionResult> AddDailySessions([Required,FromBody] AddDailySessionsRequste requste)
        {
            throw new NotImplementedException();
        }
        [HttpGet("GetAllDailySessions")]
        public Task<IActionResult> GetAllDailySessions([Required,FromQuery] Guid divissionId)
        {
            throw new NotImplementedException();
        }
        [HttpGet("GetAllDailySessionsByDate")]
        public Task<IActionResult> GetAllDailySessionsByDate([Required,FromBody] GetAllDailySessionsByDateRequste requste)
        {
            throw new NotImplementedException();
        }
    }
}
