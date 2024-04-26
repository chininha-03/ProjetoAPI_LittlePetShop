using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }

        [Required(ErrorMessage = "O nome do Produto é obrigatório!")]
        [Display(Name = "Nome do Produto")]
        public string ProdutoNome { get; set; }

        [Required(ErrorMessage = "O preço do Produto é obrigatório!")]
        [Display(Name = "Preço")]
        public string Preco { get; set; }

    }
}