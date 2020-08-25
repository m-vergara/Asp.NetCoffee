using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Asp.NetCoffeeTool.Controllers
{
   

    [Route("api/[controller]")]
    [ApiController]
    public class ListenerController : ControllerBase
    {
        private readonly ILogger<ListenerController> _logger;
        private bool _debug;
        public ListenerController(ILogger<ListenerController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("")]
        public IActionResult Post()
        {
            string statusData = null;
            var reader = new StreamReader(HttpContext.Request.Body);
            statusData = reader.ReadToEnd();
            _logger.LogInformation("Received http post data " + statusData);

            return Ok(statusData);
        }
    }
}