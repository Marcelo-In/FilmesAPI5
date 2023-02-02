using System.ComponentModel.DataAnnotations;

namespace FilmesAPI5.Data.Dtos.Cinemas
{
    public class CreateCinemaDto
    {
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }
        public int EnderecoId { get; set; }
        public int GerenteId { get; set; }
    }
}
