using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace explorer_api.Controllers {
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ValuesController: Controller {
        [HttpGet]
        public IActionResult Get() => Ok( new { Controller = GetType().Name, Version = HttpContext.GetRequestedApiVersion().ToString() } );
        
    }
}