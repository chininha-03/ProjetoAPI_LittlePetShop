using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }

        [Required(ErrorMessage = "Tipo de animal é obrigatório.")]
        [Display(Name = "Tipo de Animal")]
        [StringLength(20)]

        public string TipoAnimal { get; set; }
        public string PetId { get; set; }
        public Pet? Pet { get; set; }
    }
}
