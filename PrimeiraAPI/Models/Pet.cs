using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class Pet
    {
        public Guid PetId { get; set; }

        [Required(ErrorMessage = "Nome do Pet é obrigatório")]
        [Display(Name = "Nome do Pet")]
        [StringLength(20)]
        public string NomePet { get; set; }

        [Required(ErrorMessage = "Tamanho do Pet é obrigatório")]
        [Display(Name = "Tamanho do Pet")]
        public decimal TamanhoPet { get; set; }

        public int IdCliente { get; set; }
        public Cliente? Cliente { get; set; }
    }
}
