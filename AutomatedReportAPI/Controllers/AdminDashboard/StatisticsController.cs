using AutomatedReportAPI.Services;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.Responces;
using Microsoft.AspNetCore.Mvc;

namespace AutomatedReportAPI.Controllers.AdminDashboard
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class StatisticsController : ControllerBase, IStatisticsService<IActionResult>
    {
        private readonly IStatisticsService<GeneralResponse> statisticsService;
        public StatisticsController(IStatisticsService<GeneralResponse> statisticsService)
        {
            this.statisticsService = statisticsService;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var Result = await statisticsService.GetAll();
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
