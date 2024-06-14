using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppTeatro.Data;

namespace WebAppTeatro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        //se utiliza el context para enviar datos a la DB
        private readonly ApplicationDBContext _dbContext;

        public UsuarioController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        /*Validamos la conexion al Servidor*/
        [HttpGet("ConexionServidor")]

        public async Task<ActionResult<string>> GetConexionServidor()
        {
            return "Conectado al servidor local";
        }

        /*Validamos conexion a DB*/
        [HttpGet("ConexionUsuarios")]
        public async Task<ActionResult<string>> GetConexionUsuarios()
        {
            try
            {
                var respuesta = await _dbContext.Usuarios.ToListAsync();
                return "Conectado a la DB";
            }
            catch (Exception ex)
            {

                return StatusCode(500, $"Error de conexión: {ex.Message}");
            }
        }

    }
}
