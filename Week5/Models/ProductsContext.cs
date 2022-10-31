using Microsoft.EntityFrameworkCore;
namespace MattsSportsEmporium.Models
{
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext>options)
            { }
        public  DbSet<Products> Products { get; set; }
    }
}
