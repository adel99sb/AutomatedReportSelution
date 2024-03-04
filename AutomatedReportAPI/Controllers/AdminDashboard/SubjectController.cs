using AutomatedReportAPI.Infrastructure.Contracts;
using AutomatedReportAPI.Services;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportAPI.Services.EntityServices.Service;
using AutomatedReportCore.Responces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AutomatedReportAPI.Controllers.AdminDashboard
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class SubjectController : ControllerBase, ISubjectService<IActionResult>
    {
        private readonly ISubjectService<GeneralResponse> subjectService;
        public SubjectController(ISubjectService<GeneralResponse> subjectService)
        {
            this.subjectService = subjectService;
        }
        [HttpGet("GetAllSubjects")]
        public Task<IActionResult> GetAllSubjects([Required, FromQuery] Guid divisionId)
        {
            throw new NotImplementedException();
        }
    }
}
