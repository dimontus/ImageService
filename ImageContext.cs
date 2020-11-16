using Microsoft.EntityFrameworkCore;
using ImageService.Entities;

namespace ImageService
{
    public class ImageContext : DbContext
    {
        public DbSet<ImageEntity> Images { get; set; }

        public ImageContext(DbContextOptions<ImageContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}