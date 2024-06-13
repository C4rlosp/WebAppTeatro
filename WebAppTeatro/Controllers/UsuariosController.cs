using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppTeatro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        [HttpGet("ConexionServidor")]
        public async Task<ActionResult<string>> GetEjemplo()
        {
            return "conectado al servidor";
        }
    }
}
