using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Loja.Product.Models
{
    public class ProductModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("product_id")]
        public int ProductId { get; set; }

        [BsonElement("product_name")]
        public string? ProductName { get; set; }

        [BsonElement("product_size")]
        public double ProductSize { get; set; }

        [BsonElement("product_value")]
        public double ProductValue { get; set; }
    }
}
