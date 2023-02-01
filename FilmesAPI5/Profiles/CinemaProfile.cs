using AutoMapper;
using FilmesAPI5.Data.Dtos;
using FilmesAPI5.Models;

namespace FilmesAPI5.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<Cinema, ReadCinemaDto>();
            CreateMap<UpdateCinemaDto, Cinema>();
        }
    }
}
