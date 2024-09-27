using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace Moodle_with_MongoDB.WebModel
{
    public class UpdateTeacherRequest
    {
        [Required]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }
        public string? Name { get; set; }
        public string? DOB { get; set; }
        public string? Address { get; set; }
    }
}
