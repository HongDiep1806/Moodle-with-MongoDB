using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moodle_with_MongoDB.Model;
using Moodle_with_MongoDB.Repository;
using Moodle_with_MongoDB.Service;
using Moodle_with_MongoDB.WebModel;

namespace Moodle_with_MongoDB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacheService;
        public TeacherController(ITeacherService teacherService)
        {
            _teacheService = teacherService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var students = _teacheService.GetAll();
            return Ok(students);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateTeacherRequest request)
        {
            _teacheService.Create(request);
            return Ok();

        }

        [HttpDelete]
        public IActionResult Delete(DeleteTeacherRequest request)
        {
            _teacheService.Delete(request);
            return Ok();

        }

        [HttpPut]
        public IActionResult Update([FromForm] UpdateTeacherRequest request)
        {
            _teacheService.Update(request);
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
