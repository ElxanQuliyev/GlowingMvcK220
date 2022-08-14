using System.ComponentModel.DataAnnotations;

namespace GlowingMvcK220.Models
{
    public class Category
    {
        public int Id { get; set; }

        [MaxLength(250)]
        public string CategoryName { get; set; } = null!;
        [MaxLength(650)]
        public string? PhotoUrl { get; set; }
    }
}
