using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using Moodle_with_MongoDB.Model;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Moodle_with_MongoDB.WebModel
{
    public class CreateUserRequest
    {
        [Required]
        public string IRN { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Name { get; set; }
        public string DOB { get; set; }
        public string Address { get; set; }
        public bool IsDeleted { get; set; } = false;
        public string? Avatar { get; set; }
        public UserType UserType { get; set; }
    }
}
