using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Store.Clients.Models
{
    public class ClientModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("email")]
        public string? Email { get; set; }

        [BsonElement("address")]
        public string? Address { get; set; }

        [BsonElement("telphone")]
        public string? Telphone { get; set; }

        [BsonElement("cpf")]
        public string? CPF { get; set; }

        [BsonElement("age")]
        public int Age { get; set; }

        [BsonElement("cep")]
        public string? CEP { get; set; }

        [BsonElement("birthdate")]
        public DateTime? Birthdate { get; set; }
    }
}

