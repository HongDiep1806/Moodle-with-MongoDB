using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Moodle_with_MongoDB.WebModel;

namespace Moodle_with_MongoDB.Model
{
    public class Teacher
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? ID { get; set; }
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
        
    }
}
