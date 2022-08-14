using System.ComponentModel.DataAnnotations;

namespace GlowingMvcK220.Models
{
    public class BlogCategory
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string Name { get; set; } = null!;
    }
}
