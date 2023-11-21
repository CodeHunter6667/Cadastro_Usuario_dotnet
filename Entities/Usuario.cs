using Microsoft.AspNetCore.Identity;

namespace UsuarioApi.Entities
{
    public class Usuario : IdentityUser
    {
        public DateTime DataNascimento { get; set; }
        public Usuario() : base()
        {
            
        }
    }
}
