using FluentResults;
using Microsoft.AspNetCore.Mvc;
using UsuariosApi5.Data.Requests;
using UsuariosApi5.Services;

namespace UsuariosApi5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private LoginService _loginService;

        public LoginController(LoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        public IActionResult LogaUsuario(LoginRequest request)
        {
            Result resultado = _loginService.LogaUsuario(request);
            if (resultado.IsFailed) return Unauthorized();
            return Ok();
        }
    }
}
