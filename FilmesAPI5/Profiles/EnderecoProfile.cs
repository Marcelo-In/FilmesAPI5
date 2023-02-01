using AutoMapper;
using FilmesAPI5.Data.Dtos;
using FilmesAPI5.Models;

namespace FilmesAPI5.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<Endereco, ReadEnderecoDto>();
            CreateMap<UpdateEnderecoDto, Endereco>();
        }
    }
}
