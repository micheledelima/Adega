using Store.Product.Interfaces.Repositories;
using Store.Product.Interfaces.Services;
using Store.Product.Models;

namespace Store.Product.Services
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
