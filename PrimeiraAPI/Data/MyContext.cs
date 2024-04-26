using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Models;

namespace PrimeiraAPI.Data
{
    public class MyContext : IdentityDbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Animal> Animais { get; set; }
        public DbSet<CategoriaProduto> CategoriasProduto { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Servicos> Servicos { get; set; }
        public DbSet<Venda> Vendas { get; set; }

        public DbSet<VendaProduto> VendasProduto { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Venda>().ToTable("Venda");
            modelBuilder.Entity<Servicos>().ToTable("Servicos");
            modelBuilder.Entity<Produto>().ToTable("Produto");
            modelBuilder.Entity<Pet>().ToTable("Pet");
            modelBuilder.Entity<CategoriaProduto>().ToTable("CategoriaProduto");
            modelBuilder.Entity<Animal>().ToTable("Animal");
        }
    }
}
