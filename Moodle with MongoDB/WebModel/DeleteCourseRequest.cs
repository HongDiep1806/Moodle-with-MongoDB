using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Moodle_with_MongoDB.WebModel
{
    public class DeleteCourseRequest
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }
    }
}
