using System.ComponentModel.DataAnnotations;

namespace UsuariosApi5.Data.Requests
{
    public class AtivaContaRequest
    {
        [Required]
        public int UsuarioId { get; set; }
        [Required]
        public string CodigoDeAtivacao { get; set; }
    }
}
