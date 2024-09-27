using Microsoft.AspNetCore.Mvc;
using Moodle_with_MongoDB.Service;
using Moodle_with_MongoDB.WebModel;

namespace Moodle_with_MongoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var students = _studentService.GetAll();
            return Ok(students);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateStudentRequest request)
        {
            _studentService.Create(request);
            return Ok();

        }

        [HttpDelete]
        public IActionResult Delete(DeleteStudentRequest request)
        {
            _studentService.Delete(request);
            return Ok();

        }

        [HttpPut]
        public IActionResult Update([FromForm] UpdateStudentRequest request)
        {
            _studentService.Update(request);
            return Ok();

        }
    }
}
