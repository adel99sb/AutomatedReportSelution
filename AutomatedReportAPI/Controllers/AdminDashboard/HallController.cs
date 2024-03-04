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
    public class HallController : ControllerBase, IHallService<IActionResult>
    {
        [HttpPost("AddHall")]
        public Task<IActionResult> AddHall([Required,FromBody] AddHallRequste requste)
        {
            throw new NotImplementedException();
        }
        [HttpDelete("DeleteHall")]
        public Task<IActionResult> DeleteHall([Required, FromQuery] Guid id)
        {
            throw new NotImplementedException();
        }
        [HttpPut("EditeHall")]
        public Task<IActionResult> EditeHall([Required,FromBody] EditeHallRequste requste)
        {
            throw new NotImplementedException();
        }
        [HttpGet("GetAllHalls")]
        public Task<IActionResult> GetAllHalls()
        {
            throw new NotImplementedException();
        }
        [HttpGet("GetHallById")]
        public Task<IActionResult> GetHallById([Required,FromQuery] Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
