using Loja.Product.Interfaces.Repositories;
using Loja.Product.Interfaces.Services;
using Loja.Product.Models;

namespace Loja.Product.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public void SetProduct(ProductModel productModel)
        {
            Console.WriteLine("SetProduct");
            if (productModel != null)
                _ = _repository.CreateAsync(productModel);
            Console.WriteLine("Model: " + productModel);
        }
    }
}
