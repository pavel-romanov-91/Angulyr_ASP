
namespace HoptSport.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }

    }
}
