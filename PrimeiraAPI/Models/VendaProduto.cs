namespace PrimeiraAPI.Models
{
    public class VendaProduto
    {
        public int VendaProdutoId { get; set; }
        public int VendaId { get; set; }
        public Venda? Venda { get; set; }
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }
    }
}
