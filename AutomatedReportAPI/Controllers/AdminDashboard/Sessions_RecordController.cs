using AutomatedReportAPI.AppData.Models;
using AutomatedReportAPI.Services;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportAPI.Services.EntityServices.Service;
using AutomatedReportCore.Requstes.AdminDashboard;
using AutomatedReportCore.Responces;
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
        private readonly ISessions_RecordService<GeneralResponse> sessionService;
        public Sessions_RecordController(ISessions_RecordService<GeneralResponse> sessionService)
        {
            this.sessionService = sessionService;
        }

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
        public async Task<IActionResult> GetAllDays()
        {
            try
            {
                var Result = await sessionService.GetAllDays();
                var Response = Result.StatusCode.ToActionResult(Result);
                return Response;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
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
        public async Task<IActionResult> GetAllSessionsGroupedByDays([Required, FromQuery] Guid divisionId)
        {
            try
            {
                var Result = await sessionService.GetAllSessionsGroupedByDays(divisionId);
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
