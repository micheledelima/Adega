using Loja.Clients.Interfaces.Repositories;
using Loja.Clients.Models;
using MongoDB.Driver;

namespace Loja.DataBase.Product.Repositories
{
    public class ClientRepository : IClientRepository
    {
        // String de conexão 
        private readonly string _connectionString;
        private readonly IMongoCollection<ClientModel> _collection;
        public ClientRepository()
        {
            _connectionString = "mongodb://localhost:27017";
            // Criar uma instância do MongoClient com a string de conexão
            MongoClient client = new(_connectionString);
            // Obter uma referência ao banco de dados
            IMongoDatabase database = client.GetDatabase("nossa_lojinha");
            _collection = database.GetCollection<ClientModel>("client");
        }
    }
}
