using System;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingGateWay
{
	[Route("[action]")]
	[ApiController]

	public class ProxyController : ControllerBase
	{
		private readonly HttpClient _httpclient;

		public ProxyController(IHttpClientFactory httpClientFactory)
		{
			_httpclient = httpClientFactory.CreateClient();
		}

		[HttpGet]

		public async Task<IActionResult> Customers()
			=> await ProxyTo("htttp://localhost:7204/costumers");

        [HttpGet]

        public async Task<IActionResult> Orders()
            => await ProxyTo("htttp://localhost:7196/orders");

		public async Task<ContentResult> ProxyTo(string url)
			=> Content(await _httpclient.GetStringAsync(url));

    }
}

