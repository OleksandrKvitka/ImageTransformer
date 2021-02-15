using Microsoft.EntityFrameworkCore;

namespace ImageTransformer.Models
{
    public class ImageDbContext : DbContext
    {
        public DbSet<ImageModel> Images { get; set; }
        public ImageDbContext(DbContextOptions<ImageDbContext> options) : base(options)
        {
            
        }
    }
}
