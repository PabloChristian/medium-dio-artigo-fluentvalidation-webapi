using Microsoft.AspNetCore.Mvc;
using medium_dio_artigo_fluentvalidation_webapi.Models;

namespace medium_dio_artigo_fluentvalidation_webapi.Controllers
{
    [ApiController]
    [Route("cliente")]
    public class ClienteController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get() => Ok();

        [HttpPost]
        public IActionResult Post([FromBody] Cliente _) => Ok();
    }
}
