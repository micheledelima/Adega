using Adega.Product.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Adega.DataBase.Product.Repositories
{
    public class ProductRepository
    {
        private readonly IMongoCollection<ProductModel> _productCollection;

        public ProductRepository(
        IOptions<StoreDatabaseSettings> storeDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                storeDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                storeDatabaseSettings.Value.DatabaseName);

            _productCollection = mongoDatabase.GetCollection<ProductModel>(
                storeDatabaseSettings.Value.ProductCollectionName);
        }

        //criar crud necessário para cada entidade
        public async Task CreateAsync(ProductModel productModel) =>
        await _productCollection.InsertOneAsync(productModel);

        public async Task UpdateAsync(string id, ProductModel productModel) =>
            await _productCollection.ReplaceOneAsync(x => x.Id == id, productModel);

        public async Task RemoveAsync(string id) =>
            await _productCollection.DeleteOneAsync(x => x.Id == id);
    }
}
