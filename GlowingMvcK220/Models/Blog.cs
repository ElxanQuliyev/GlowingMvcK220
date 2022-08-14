using System.ComponentModel.DataAnnotations;

namespace GlowingMvcK220.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [MaxLength(300)]
        public string Name { get; set; } = null!;
        [MaxLength(3000)]
        public string? Description { get; set; }
        [MaxLength(650)]
        public string? PhotoUrl { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
