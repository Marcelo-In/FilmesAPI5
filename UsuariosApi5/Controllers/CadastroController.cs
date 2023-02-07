using Microsoft.AspNetCore.Mvc;
using UsuariosApi5.Data.Dtos;

namespace UsuariosApi5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CadastroController : ControllerBase
    {

        [HttpPost]
        public IActionResult CadastraUsuario(CreateUsuarioDto createDto)
        {
            return Ok();
        }
    }
}
