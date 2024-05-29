using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Text.Json.Serialization;

namespace Moodle_with_MongoDB.Model
{
    public class Course
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }
        [BsonElement("Name")]
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [BsonElement("Teacher ID")]
        [JsonPropertyName("Teacher ID")]
        public string? TeacherID { get; set; }
        [BsonElement("Is Deleted")]
        [JsonPropertyName("Is Deleted")]
        public bool IsDeleted { get; set; } = false;
    }
}
