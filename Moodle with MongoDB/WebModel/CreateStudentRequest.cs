using System.ComponentModel.DataAnnotations;

namespace Moodle_with_MongoDB.WebModel
{
    public class CreateStudentRequest
    {
        [Required]
        public string IRN { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public string Address { get; set; }
    }
}
