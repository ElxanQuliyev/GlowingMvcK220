using GlowingMvcK220.Models;

namespace GlowingMvcK220.ViewModels
{
    public class HomeVM
    {
        public List<Section1>? Section1s { get; set; }
        public List<Product>? FavoriteProducts { get; set; }
        public List<Product>? FeaturedProducts { get; set; }
        public List<Category> Categories { get; set; }
    }
}
