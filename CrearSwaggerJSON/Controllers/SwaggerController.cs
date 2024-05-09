using CrearSwaggerJSON.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrearSwaggerJSON.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SwaggerController : ControllerBase
    {
        [HttpPost]
        public IActionResult GenerateSwagger([FromBody] SwaggeParametrosModel parametros)
        {
            var swaggerDoc = new
            {
                openapi = "3.0.0", //aca puedes pasar la version como parametro tambien o dejarla fija..
                info = new
                {
                    title = parametros.Title,
                    description = parametros.Description,
                    version = parametros.Version
                },
                paths = parametros.Paths.ToDictionary(
                    path => path.Key,
                    path => new { get = new { summary = path.Value.Summary, operationId = path.Value.OperationId, tags = path.Value.Tags } }
                )
            };

            return Ok(swaggerDoc);
        }
    }
}
