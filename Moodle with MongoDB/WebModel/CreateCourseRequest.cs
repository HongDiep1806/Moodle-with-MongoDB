using System.ComponentModel.DataAnnotations;

namespace Moodle_with_MongoDB.WebModel
{
    public class CreateCourseRequest
    {
        [Required]
        public string Name { get; set; }
        public string? TeacherID { get; set; }
    }
}
