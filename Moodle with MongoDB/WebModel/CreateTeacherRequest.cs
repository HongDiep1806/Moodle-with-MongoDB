using System.ComponentModel.DataAnnotations;

namespace Moodle_with_MongoDB.WebModel
{
    public class CreateTeacherRequest
    {
        [Required]
        public string Name { get; set; }

        public string? DOB { get; set; }

        public string? Address { get; set; }
    }
}
