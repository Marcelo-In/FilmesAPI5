using AutoMapper;
using FilmesAPI5.Data.Dtos.Gerentes;
using FilmesAPI5.Models;
using System.Linq;

namespace FilmesAPI5.Profiles
{
    public class GerenteProfile : Profile
    {
        public GerenteProfile()
        {
            CreateMap<CreateGerenteDto, Gerente>();
            CreateMap<Gerente, ReadGerenteDto>()
                .ForMember(gerente => gerente.Cinemas, opts => opts
                .MapFrom(gerente => gerente.Cinemas.Select
                (c => new { c.Id, c.Nome, c.Endereco, c.EnderecoId })));
            CreateMap<UpdateGerenteDto, Gerente>();
        }
    }
}
