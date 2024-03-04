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
    public class Test_MarkController : ControllerBase, ITestMarkService<IActionResult>
    {
        [HttpPost("AddTestMarks")]
        public Task<IActionResult> AddTestMarks([Required,FromBody] AddTestMarkRequste requste)
        {
            throw new NotImplementedException();
        }
        [HttpGet("GetAllTestMarks")]
        public Task<IActionResult> GetAllTestMarks([Required,FromQuery] Guid testId)
        {
            throw new NotImplementedException();
        }
        [HttpPut("UpdateTestMarks")]
        public Task<IActionResult> UpdateTestMarks([Required,FromBody] EditeTestMarksRequste requste)
        {
            throw new NotImplementedException();
        }
    }
}
