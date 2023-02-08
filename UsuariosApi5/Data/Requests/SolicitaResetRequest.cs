using System.ComponentModel.DataAnnotations;

namespace UsuariosApi5.Data.Requests
{
    public class SolicitaResetRequest
    {
        [Required]
        public string Email { get; set; }
    }
}
