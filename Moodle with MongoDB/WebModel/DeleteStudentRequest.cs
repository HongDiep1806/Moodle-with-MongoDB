using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Moodle_with_MongoDB.WebModel
{
    public class DeleteStudentRequest
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }
    }
}
