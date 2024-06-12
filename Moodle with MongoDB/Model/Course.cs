using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Text.Json.Serialization;
using MongoDB.Driver;

namespace Moodle_with_MongoDB.Model
{
    public class Course
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }

        [BsonElement]
        public string Name { get; set; }

        [BsonElement]
        public string? TeacherID { get; set; }

        [BsonElement]
        public bool IsDeleted { get; set; } = false;
    }
}
