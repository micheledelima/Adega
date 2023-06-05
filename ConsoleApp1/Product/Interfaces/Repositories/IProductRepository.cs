using Store.Product.Models;

namespace Store.Product.Interfaces.Repositories
{
    public interface IProductRepository
    {
        public Task CreateAsync(ProductModel productModel);

        public Task UpdateAsync(ProductModel productModel);

        public Task RemoveAsync(ProductModel productModel);

        public Task<bool> FindOneAsync(ProductModel productModel);

        public Task<List<ProductModel>> FindAllAsync();

        public Task<ProductModel> FindByProductNameAsync(string name);

        public Task<ProductModel> FindByProductIdAsync(int code);
    }
}
