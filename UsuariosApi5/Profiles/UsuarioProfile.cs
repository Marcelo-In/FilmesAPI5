using AutoMapper;
using UsuariosApi5.Data.Dtos;
using UsuariosApi5.Models;

namespace UsuariosApi5.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto, Usuario>();
        }
    }
}
