using CatalogoProdutos.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalogoProdutos.Data
{
    public class CatalogoProdutosDbContext : DbContext
    {
        public CatalogoProdutosDbContext(DbContextOptions<CatalogoProdutosDbContext> options) : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }
    }
}