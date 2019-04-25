using System.ComponentModel.DataAnnotations;

namespace Senai.SviGufo.WebApi.Domains
{
    public class UsuarioDomain
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [StringLength(150,MinimumLength = 3, ErrorMessage = "A senha de ter entre 3 a 150 caracteres")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Informe o tipo o usuario")]
        public string TipoUsuario { get; set; }
    }
}
