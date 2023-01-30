using AutoMapper;
using FilmesAPI5.Data.Dtos;
using FilmesAPI5.Models;

namespace FilmesAPI5.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<Filme, ReadFilmeDto>();
            CreateMap<UpdateFilmeDto, Filme>();
        }
    }
}
