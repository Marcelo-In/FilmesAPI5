using FluentResults;
using Microsoft.AspNetCore.Mvc;
using UsuariosApi5.Data.Dtos;
using UsuariosApi5.Data.Requests;
using UsuariosApi5.Services;

namespace UsuariosApi5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CadastroController : ControllerBase
    {
        private CadastroService _cadastroService;

        public CadastroController(CadastroService cadastroService)
        {
            _cadastroService = cadastroService;
        }

        [HttpPost]
        public IActionResult CadastraUsuario(CreateUsuarioDto createDto)
        {
            Result resultado = _cadastroService.CadastraUsuario(createDto);
            if (resultado.IsFailed) return StatusCode(500);
            return Ok(resultado.Successes);
        }

        [HttpGet("/ativa")]
        public IActionResult AtivaContaUsuario([FromQuery]AtivaContaRequest request)
        {
            Result resultado = _cadastroService.AtivaContaUsuario(request);
            if(resultado.IsFailed) return StatusCode(500);
            return Ok(resultado.Successes);
        }
    }
}
