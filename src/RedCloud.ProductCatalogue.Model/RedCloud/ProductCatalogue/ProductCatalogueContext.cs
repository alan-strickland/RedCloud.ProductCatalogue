using Microsoft.EntityFrameworkCore;

namespace RedCloud.ProductCatalogue
{
    public class ProductCatalogueContext : DbContext
    {
        public ProductCatalogueContext(DbContextOptions<ProductCatalogueContext> options)
            : base(options)
        {
        }

        public DbSet<Model.Product> Products { get; set; }

    }
}