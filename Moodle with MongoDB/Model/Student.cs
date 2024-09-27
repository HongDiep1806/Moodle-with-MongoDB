using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Text.Json.Serialization;

namespace Moodle_with_MongoDB.Model
{
    public class Student
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? ID { get; set; }
        [BsonElement("IRN")]
        [JsonPropertyName("IRN")]
        public string IRN { get; set; }
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
        public string Avatar { get; set; }
    }
}
