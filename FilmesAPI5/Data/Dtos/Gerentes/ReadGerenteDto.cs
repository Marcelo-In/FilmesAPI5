using FilmesAPI5.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI5.Data.Dtos.Gerentes
{
    public class ReadGerenteDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Nome { get; set; }
        public object Cinemas { get; set; }

    }
}
