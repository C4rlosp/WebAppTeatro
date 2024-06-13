using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppTeatro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        /*Validamos la conexion al Servidor local de la App*/
        [HttpGet("strConection")]

        public async Task<ActionResult<string>> GetEjemplo() 
        {
            return "Conectado al Servidor";
        }
    }
}
