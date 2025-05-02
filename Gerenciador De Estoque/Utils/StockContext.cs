using Gerenciamento_De_Estoque.Models;
using Microsoft.EntityFrameworkCore;

namespace Gerenciador_De_Estoque.Utils;

internal class StockContext : DbContext
{
    public DbSet<ProductModel> Product { get; set; }

    private readonly string connectionString = "server=localhost;database=GerenciadorDeEstoque;user=root;password=luiz";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
}
