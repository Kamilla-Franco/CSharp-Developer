using Maxima.Domain;
using Microsoft.EntityFrameworkCore;

namespace Maxima.Repository
{
    public class MaximaContext : DbContext
    {
        public MaximaContext(DbContextOptions<MaximaContext> options) : base(options){}

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ProdutosClientesPedido> ProdutosClientesPedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){

            modelBuilder.Entity<Cliente>().Property(c => c.Cli_Id)
                .UseNpgsqlIdentityAlwaysColumn();

            modelBuilder.Entity<Produto>().Property(p => p.ProdutoId)
                .UseNpgsqlIdentityAlwaysColumn();

            modelBuilder.Entity<Pedido>().Property(x => x.PedidoId)
                .UseNpgsqlIdentityAlwaysColumn();
            
            modelBuilder.Entity<ProdutosClientesPedido>()
                .HasKey(PC => new {PC.ClienteId,PC.PedidoId, PC.ProdutoId});
            

        }
    }

    
}