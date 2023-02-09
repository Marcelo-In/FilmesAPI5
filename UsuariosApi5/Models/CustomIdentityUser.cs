using Microsoft.AspNetCore.Identity;
using System;

namespace UsuariosApi5.Models
{
    public class CustomIdentityUser : IdentityUser<int>
    {
        public DateTime DataNascimento { get; set; }
    }
}
