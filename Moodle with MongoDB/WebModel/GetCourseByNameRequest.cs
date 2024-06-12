using System.ComponentModel.DataAnnotations;

namespace Moodle_with_MongoDB.WebModel
{
    public class GetCourseByNameRequest
    {
        [Required]
        public string CourseName { get; set; }
    }
}
