using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GlowingMvcK220.Models
{
    public class Product
    {
        public int Id { get; set; }
        [MaxLength(300)]
        [DisplayName("Məhsul adı")]
        public string Name { get; set; } = null!;
        [MaxLength(1000)]
        [DisplayName("Aciqlama")]
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        [MaxLength(600)]
        public string? PhotoUrl { get; set; }
        [Display(Name ="New")]
        public bool IsNew { get; set; }

        [DisplayName("Recommended")]
        public bool IsFeatured { get; set; }
        [DisplayName("Favorite Product")]
        public bool IsFavorite { get; set; }
        public decimal? Rating { get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }

    }
}
