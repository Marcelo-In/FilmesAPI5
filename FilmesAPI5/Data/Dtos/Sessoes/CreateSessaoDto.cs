using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI5.Data.Dtos.Sessoes
{
    public class CreateSessaoDto
    {
        public int CinemaId { get; set; }
        public int FilmeId { get; set; }
        public DateTime HorarioDeEncerramento { get; set; }
    }
}
