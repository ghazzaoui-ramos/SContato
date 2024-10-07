using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SContatos.Models
{
    public class ContatoModel
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage ="Digite o Nome do contato")]
        public string Nome { get; set; }

        [Required (ErrorMessage = "Digite o Email do contato")]
        [EmailAddress(ErrorMessage ="O e-mai informado nao e valido!")]
        public string Email { get; set; }
         
        [Required (ErrorMessage = "Digite o Celular do contato")]
        [Phone(ErrorMessage ="O celular informado nao e valido")]
        public string Celular { get; set; }
    }
}
