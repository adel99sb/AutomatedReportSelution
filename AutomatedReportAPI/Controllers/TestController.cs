using AutomatedReportAPI.AppData.Models;
using AutomatedReportAPI.Infrastructure.Contracts;
using AutomatedReportAPI.Services;
using AutomatedReportAPI.Services.BackgroundJobs;
using Microsoft.AspNetCore.Mvc;

namespace AutomatedReportAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class TestController : ControllerBase
    {
        //private readonly WhatsAppService whatsAppService;        
        private readonly IClassRepository classRepository;
        private readonly IBackgourndJobService backgourndJobService;
        private readonly ILogger<TestController> _logger;

        public TestController(
            ILogger<TestController> logger,
            //WhatsAppService whatsAppService,
            IClassRepository classRepository,
            IBackgourndJobService backgourndJobService)
        {
            _logger = logger;
            //this.whatsAppService = whatsAppService;
            this.classRepository = classRepository;
            this.backgourndJobService = backgourndJobService;
        }
        [HttpGet("GetClasses")]
        public async Task<IActionResult> GetAllClasses()
        {            
            var result = classRepository.GetAll();
            List<string> classes = new List<string>();
            foreach (var c in result.OrderBy(v => ((int)v.Time)))
            {
                classes.Add($"{c.Name} من {c.Time.GetDisplayName()}");
            }
            var res = new Responce()
            {
                Message = "messages Sent Succesfully",
                StatusCode = Ok().StatusCode,
                ResultJson = classes
            };
            var date = new DateTime(1999,9,9);
            await backgourndJobService.SendBirthDayMessage("done bithcssssss",date);
            return Ok(res);
        }
        [HttpPost("SendMessage")]
        public async Task<IActionResult> SendMessage(string message,_Class _Class)
        {
            var reciptents = new List<string>
            {
                "+963 992 679 607",
                "+963 992 679 607",
                "+963 992 679 607"
            };
            //var res = await whatsAppService.SendMessageToList(reciptents, message);
            //Console.WriteLine(res);
            //return Ok(res);
            if (!ModelState.IsValid)
            {               
                return BadRequest(ModelState.GetErrors());
            }            
            var res = new Responce()
            {
                Message = "messages Sent Succesfully",
                StatusCode = Ok().StatusCode,
                ResultJson = reciptents
            };
            return Ok(res);
        }
    }
    public class Responce
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public object ResultJson { get; set; }
    }
}