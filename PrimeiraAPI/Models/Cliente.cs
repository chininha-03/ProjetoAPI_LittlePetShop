using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        [Required(ErrorMessage = "O nome do cliente é obrigatório.")]
        [Display(Name = "Nome do Cliente")]
        public string NomeCliente { get; set; }

        [Required(ErrorMessage = "O Telefone do cliente é obrigatório.")]
        [Display(Name = "Telefone do Cliente")]
        public string TelefoneCliente { get; set; }

        [Required(ErrorMessage = "O E-mail do cliente é obrigatório.")]
        [Display(Name = "Email do Cliente")]
        public string MailCliente { get; set; }


    }
}
