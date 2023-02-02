using System.ComponentModel.DataAnnotations;

namespace FilmesAPI5.Data.Dtos.Cinemas
{
    public class UpdateCinemaDto
    {
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }
    }
}
