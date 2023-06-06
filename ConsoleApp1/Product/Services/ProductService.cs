using MongoDB.Bson;
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

        public bool SetProduct(ProductModel productModel)
        {
            productModel.Id = ObjectId.GenerateNewId().ToString();

            if (productModel != null && ValidateProduct(productModel))
            {
                _ = _repository.CreateAsync(productModel);
                return true;
            }
            else
                return false;
        }

        public bool ValidateProduct(ProductModel productModel)
        {
            if (productModel == null)
                return false;

            var existingProduct = _repository.FindOneAsync(productModel);
            if (existingProduct.Result)
                return false;

            return true;
        }

        public List<ProductModel> GetAllProducts()
        {
            var products = _repository.FindAllAsync();
            return products.Result;
        }

        public ProductModel GetProductByProductId(int code)
        {
            var product = _repository.FindByProductIdAsync(code);
            return product.Result;
        }

        public ProductModel GetProductByProductName(string name)
        {
            var product = _repository.FindByProductNameAsync(name);
            return product.Result;
        }
    }
}
