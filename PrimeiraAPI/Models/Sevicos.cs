using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class Servicos
    {
        public int IdServicos { get; set; }

        [Display(Name = "Escolha o seu Serviço")]
        public string ServicosNome { get; set; }

    }
}


