using Store.Product.Models;

namespace Store.Product.Interfaces.Repositories
{
    public interface IProductRepository
    {
        public Task CreateAsync(ProductModel productModel);

        public Task UpdateAsync(string id, ProductModel productModel);

        public Task RemoveAsync(string id);
    }
}
