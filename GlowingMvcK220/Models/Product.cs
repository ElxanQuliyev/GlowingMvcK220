using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace GlowingMvcK220.Models
{
    public class Product
    {
        public int Id { get; set; }
        [MaxLength(300)]
        public string Name { get; set; } = null!;
        [MaxLength(1000)]
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        [MaxLength(600)]
        public string? PhotoUrl { get; set; }
        public bool IsNew { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsFavorite { get; set; }
        public decimal? Rating { get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }

    }
}
