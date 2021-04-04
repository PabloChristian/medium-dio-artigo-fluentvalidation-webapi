using System;
using Microsoft.AspNetCore.Mvc;
using medium_dio_artigo_fluentvalidation_webapi.Models;

namespace medium_dio_artigo_fluentvalidation_webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] Cliente _) => Ok();
    }
}
