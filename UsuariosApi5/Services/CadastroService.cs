using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using UsuariosApi5.Data;
using UsuariosApi5.Data.Dtos;
using UsuariosApi5.Data.Requests;
using UsuariosApi5.Models;

namespace UsuariosApi5.Services
{
    public class CadastroService
    {
        private IMapper _mapper;
        private UserManager<CustomIdentityUser> _userManager;
        private EmailService _emailService;

        public CadastroService(IMapper mapper, UserManager<CustomIdentityUser> userManager, EmailService emailService)
        {
            _mapper = mapper;
            _userManager = userManager;
            _emailService = emailService;
        }

        public Result CadastraUsuario(CreateUsuarioDto createDto)
        {
            Usuario usuario = _mapper.Map<Usuario>(createDto);
            CustomIdentityUser usuarioIdentity = _mapper.Map<CustomIdentityUser>(usuario);
            Task<IdentityResult> resultadoIdentity = _userManager.CreateAsync(usuarioIdentity, createDto.Password);
            _userManager.AddToRoleAsync(usuarioIdentity, "regular");
            if (resultadoIdentity.Result.Succeeded)
            {
                var code = _userManager.GenerateEmailConfirmationTokenAsync(usuarioIdentity).Result;
                var encodedCode = HttpUtility.UrlEncode(code);
                _emailService.EnviarEmail(new[] { usuarioIdentity.Email }, "Link de Ativação", usuarioIdentity.Id, encodedCode); ;
                return Result.Ok().WithSuccess(code);
            }
            return Result.Fail("Falha ao cadastrar o usuário");
        }

        public Result AtivaContaUsuario(AtivaContaRequest request)
        {
            var identityUser = _userManager
                .Users
                .FirstOrDefault(u => u.Id == request.UsuarioId);
            var identityResult = _userManager.ConfirmEmailAsync(identityUser, request.CodigoDeAtivacao).Result;
            if (identityResult.Succeeded) return Result.Ok();
            return Result.Fail("Falha ao ativar conta de usuário");
        }
    }
}
