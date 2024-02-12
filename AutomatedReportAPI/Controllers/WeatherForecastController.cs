using AutomatedReportAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AutomatedReportAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly WhatsAppService whatsAppService;
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, WhatsAppService whatsAppService)
        {
            _logger = logger;
            this.whatsAppService = whatsAppService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IEnumerable<WeatherForecast>> Get(string message)
        {
            var reciptents = new List<string>
            {
                "محمد وزان",
                "+963 992 679 607",
                "+963 992 679 607"
            };
            var res = await whatsAppService.SendMessageToList(reciptents,message);
            Console.WriteLine(res);
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}