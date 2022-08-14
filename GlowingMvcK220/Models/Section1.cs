using System.ComponentModel.DataAnnotations;

namespace GlowingMvcK220.Models
{
    public class Section1
    {
        public int Id { get; set; }
        [MaxLength(250)]
        public string Header { get; set; } = null!;
        [MaxLength(250)]
        public string? SubHeader { get; set; }

        [MaxLength(250)]
        public string? Description { get; set; }
        [MaxLength(650)]
        public string? PhotoUrl { get; set; }
    }
}
