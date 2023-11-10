using SportStore.Models;

namespace SportStore.Models.VieModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; } = Enumerable.Empty<Product>();
        public PagingInfo PagingInfo { get; set; } = new();
    }
}
