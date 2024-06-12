using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moodle_with_MongoDB.Model;
using Moodle_with_MongoDB.Repository;
using Moodle_with_MongoDB.WebModel;

namespace Moodle_with_MongoDB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var students = _studentRepository.GetAll();
            return Ok(students);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateStudentRequest request)
        {
            _studentRepository.Create(request);
            return Ok();

        }

        [HttpDelete]
        public IActionResult Delete(DeleteStudentRequest request)
        {
            _studentRepository.Delete(request);
            return Ok();

        }

        [HttpPut]
        public IActionResult Update([FromForm] UpdateStudentRequest request)
        {
            _studentRepository.Update(request);
            return Ok();

        }

        [HttpPost("getfilename")]
        public IActionResult GetFileName([FromForm] IFormFile file)
        {
            var filename = file.FileName;
            return Ok(filename);
        }

        // doc file excel student, import to database
    }
}
