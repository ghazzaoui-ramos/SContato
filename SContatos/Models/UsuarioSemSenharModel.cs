using SContatos.Enuns;
using System.ComponentModel.DataAnnotations;

namespace SContatos.Models
{
    public class UsuarioSemSenharModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o Nome do Usuario")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Digite o Login do Usuario")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite o Email do Usuario")]
        [EmailAddress(ErrorMessage = "O e-mai informado nao e valido!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "informe o perfil do Usuario")]
        public PerfilEnum? perfil { get; set; }
       
    }
}
