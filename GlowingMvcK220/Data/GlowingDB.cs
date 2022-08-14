using GlowingMvcK220.Models;
using Microsoft.EntityFrameworkCore;

namespace GlowingMvcK220.Data
{
    public class GlowingDB : DbContext
    {
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Section1> Section1s { get; set; } = null!;
        public DbSet<Blog> Blogs { get; set; } = null!;
        public DbSet<BlogCategory> BlogCategories { get; set; } = null!;

        public GlowingDB(DbContextOptions<GlowingDB> opt) : base(opt)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    CategoryName = "EyeLiner",
                    PhotoUrl = ""
                },
                new Category
                {
                    Id = 2,
                    CategoryName = "HairCream",
                    PhotoUrl = ""
                }
                );
            builder.Entity<Product>().HasData(
                   new Product
                   {
                       Id = 1,
                       Name = "Natural Coconut Cleansing Oil",
                       Description = "Niacinamide and Vitamin C are two anti-aging superstars but not usually formulated together because of their different pH levels.",
                       PhotoUrl = "http://templates.g5plus.net/glowing/images/product-07.jpg",
                       CategoryId = 1,
                       IsFeatured = true,
                       IsNew = true,
                       Price = 200,
                   },
                    new Product
                    {
                        Id = 2,
                        Name = "Natural 2",
                        Description = "Niacinamide 2 and Vitamin C are two anti-aging superstars but not usually formulated together because of their different pH levels.",
                        PhotoUrl = "http://templates.g5plus.net/glowing/images/product-9.jpg",
                        CategoryId = 2,
                        IsFavorite = true,
                        Price = 400,
                        Discount = 190.99M
                    }
                );
        }
    }
}
