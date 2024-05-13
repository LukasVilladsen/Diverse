using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;

namespace CBService 
{
    [ApiController]
    [Route("[controller]")]
    public class CBServiceController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly ILogger<CBServiceController> _logger;

        public CBServiceController(IConfiguration config, ILogger<CBServiceController> logger)
        {
            _config = config;
            _logger = logger;
        }

        [HttpGet("GetService")]
        [ProducesResponseType(typeof((string hostname, int time)), 200)]
        public IActionResult GetService()
        {
            var isFail = _config["ToFail"] == "yes";
            string hostname = System.Net.Dns.GetHostName();
            _logger.LogDebug($"Fail condition for {hostname} is set to {isFail}");
            var seconds = DateTime.Now.Second;
            var hasError = (seconds > 30 && seconds < 45);

            if (hasError && isFail)
            {
                return StatusCode(503); // Returnerer en fejlstatuskode 503 (Service Unavailable)
            }
            else
            {
                return Ok(new { hostname, seconds }); // Returnerer en succesfuld respons med hostname og seconds
            }
        }
    }
}
