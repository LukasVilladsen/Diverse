[HttpGet("GetService")]
[ProducesResponseType(typeof((string hostname, int time)), 200)]
public IActionResult GetService()
{
var isFail = _config["ToFail"] == "yes";
string hostname = System.Net.Dns.GetHostName();
_logger.LogDebug($"Fail condition for {hostname} is set to {isFail}");
var seconds = DateTime.Now.Second;
var hasError = (seconds > 30 && seconds < 45);
if (hasError && isFail) {
return StatusCode(503);
} else {
return Ok( new { hostname, seconds } );
}
}