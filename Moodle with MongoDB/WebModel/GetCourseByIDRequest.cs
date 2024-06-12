using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace Moodle_with_MongoDB.WebModel
{
    public class GetCourseByIDRequest
    {
        [Required]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CourseID { get; set; }
    }
}
