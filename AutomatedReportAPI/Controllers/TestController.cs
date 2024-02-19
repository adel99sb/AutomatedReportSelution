using AutomatedReport_Core;
using AutomatedReportAPI.AppData.Models;
using AutomatedReportAPI.Infrastructure.Contracts;
using AutomatedReportAPI.Services;
using AutomatedReportAPI.Services.BackgroundJobs;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AutomatedReportAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "v2")]
    public class TestController : ControllerBase
    {
        //private readonly WhatsAppService whatsAppService;        
       // private readonly IClassRepository classRepository;
        private readonly IBackgourndJobService backgourndJobService;
        private readonly ILogger<TestController> _logger;

        public TestController(
            ILogger<TestController> logger,
            //WhatsAppService whatsAppService,
            //IClassRepository classRepository,
            IBackgourndJobService backgourndJobService)
        {
            _logger = logger;
           // this.whatsAppService = whatsAppService;
            //this.classRepository = classRepository;
            this.backgourndJobService = backgourndJobService;
        }
        [HttpGet("Set_BirthDay")]
        public async Task<IActionResult> Set_BirthDay()
        {            
            //var result = classRepository.GetAll();
            List<string> classes = new List<string>();
            var date = new DateTime(1999, 9, 9);
            await backgourndJobService.SendBirthDayMessage("done bithcssssss", date);
            return Ok();
        }
        [HttpPost("SendMessage")]
        public async Task<IActionResult> SendMessage([FromQuery][Required]string Message)
        {
            var reciptents = new List<string>
            {
                //"+963 998 711 158",
                //"+963 998 711 158",
                "+963 992 679 607",
                "+963 992 679 607"
            };
            //try
            //{
            //    var res = whatsAppService.SendMessageToList(reciptents, Message);
            //    if (res.IsCompleted)
            //        return Ok(res.Result);
            //    else
            //        return BadRequest(res.Result);
            //}
            //catch (Exception ex)
            //{
            //    return BadRequest(ex.Message);
            //}            
            return Ok();
        }
    }    
}