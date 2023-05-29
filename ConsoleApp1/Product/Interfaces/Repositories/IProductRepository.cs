using Loja.Product.Models;

namespace Loja.Product.Interfaces.Repositories
{
    public interface IProductRepository
    {
        public Task CreateAsync(ProductModel productModel);

        public Task UpdateAsync(string id, ProductModel productModel);

        public Task RemoveAsync(string id);
    }
}
