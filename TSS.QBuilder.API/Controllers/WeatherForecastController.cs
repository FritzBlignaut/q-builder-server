using Microsoft.AspNetCore.Mvc;
using TSS.QBuilder.Contracts;

namespace TSS.QBuilder.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILoggerManager _logger;

        public WeatherForecastController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInfo("Fetching weather data from the WeatherForecastController");
            _logger.LogDebug("Debugging information from the WeatherForecastController");
            _logger.LogWarn("Warning from the WeatherForecastController");
            _logger.LogError("Error from the WeatherForecastController");

            return new string[] { "value1", "value2" };
        }
    }
}
