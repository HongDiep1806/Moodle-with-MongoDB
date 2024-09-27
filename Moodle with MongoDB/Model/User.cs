using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Text.Json.Serialization;

namespace Moodle_with_MongoDB.Model
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }
        [BsonElement("IRN")]
        [JsonPropertyName("IRN")]
        public string IRN { get; set; }
        [BsonElement("Password")]
        [JsonPropertyName("Password")]
        public string Password { get; set; }

        [BsonElement("Name")]
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [BsonElement("DOB")]
        [JsonPropertyName("DOB")]
        public string DOB { get; set; }
        [BsonElement("Address")]
        [JsonPropertyName("Address")]
        public string Address { get; set; }
        [BsonElement("IsDeleted")]
        [JsonPropertyName("IsDeleted")]
        public bool IsDeleted { get; set; } = false;
        [BsonElement("Avatar")]
        [JsonPropertyName("Avatar")]
        public string? Avatar { get; set; }
        [BsonElement("UserType")]
        [JsonPropertyName("UserType")]
        public UserType UserType { get; set; }
    }
}
