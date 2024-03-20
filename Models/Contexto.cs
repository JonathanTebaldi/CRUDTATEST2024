using Microsoft.EntityFrameworkCore;

namespace CRUDTATEST2024.Models
{
    
    public class Contexto:DbContext
    {
        public Contexto(DbContextOptions<Contexto> options): base(options) {

        }
        public DbSet<Cliente> Clientes { get; set;}
        public DbSet<Produto> Produtos { get; set;}
        public DbSet<Venda> Venda { get; set;}
        public DbSet<Item> Items { get; set;}
    }
}
