using MongoDB.Driver;
using Store.Product.Interfaces.Repositories;
using Store.Product.Models;

namespace Store.DataBase.Product.Repositories
{
    public class ProductRepository : IProductRepository
    {
        // String de conexão 
        private readonly string _connectionString;
        private readonly IMongoCollection<ProductModel> _collection;
        public ProductRepository()
        {
            _connectionString = "mongodb://localhost:27017";
            // Criar uma instância do MongoClient com a string de conexão
            MongoClient client = new(_connectionString);
            // Obter uma referência ao banco de dados
            IMongoDatabase database = client.GetDatabase("nossa_lojinha");
            _collection = database.GetCollection<ProductModel>("product");
        }

        //criar crud necessário para cada entidade
        public async Task CreateAsync(ProductModel productModel)
        {
            try
            {
                await _collection.InsertOneAsync(productModel);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task UpdateAsync(string id, ProductModel productModel)
        {
            try
            {
                _ = await _collection.ReplaceOneAsync(x => x.Id == id, productModel);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task RemoveAsync(string id)
        {
            try
            {
                _ = await _collection.DeleteOneAsync(x => x.Id == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
