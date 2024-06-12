using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using Moodle_with_MongoDB.Model;

namespace Moodle_with_MongoDB.WebModel
{
    public class ReplaceCourseRequest
    {
        [Required]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CourseID { get; set; }
       
    }
}
