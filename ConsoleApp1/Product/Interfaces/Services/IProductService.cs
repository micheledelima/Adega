using Store.Product.Models;

namespace Store.Product.Interfaces.Services
{
    public interface IProductService
    {
        public bool SetProduct(ProductModel productModel);

        public bool ValidateProduct(ProductModel productModel);

        public List<ProductModel> GetAllProducts();

        public ProductModel GetProductByProductId(int code);

        public ProductModel GetProductByProductName(string name);
    }
}
