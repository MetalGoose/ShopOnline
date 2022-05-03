using ShopOnline.Api.Entities;

namespace ShopOnline.Api.Repositories.Contracts
{
    public interface IProductRepository
    {
        Task<Product> GetItemAsync(int id);
        Task<ProductCategory> GetCategoryAsync(int id);
        Task<IEnumerable<Product>> GetItemsAsync();
        Task<IEnumerable<ProductCategory>> GetCategoriesAsync();
    }
}
