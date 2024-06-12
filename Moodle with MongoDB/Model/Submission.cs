using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Text.Json.Serialization;

namespace Moodle_with_MongoDB.Model
{
    public class Submission
    {
        [BsonElement("Course ID")]
        [JsonPropertyName("Course ID")]
        public string CourseID { get; set; }
        [BsonElement("Assignment ID")]
        [JsonPropertyName("Assignment ID")]
        public string AssignmentID { get; set; }
        [BsonElement("Answer")]
        [JsonPropertyName("Answer")]
        public string Answer { get; set; }
        [BsonElement("Score")]
        [JsonPropertyName("Score")]
        public int Score { get; set; }
        [BsonElement("Is Marked")]
        [JsonPropertyName("Is Marked")]
        public bool IsMarked { get; set; } = false;
    }
}
