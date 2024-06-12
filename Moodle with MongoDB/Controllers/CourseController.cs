using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver.Linq;
using Moodle_with_MongoDB.Repository;
using Moodle_with_MongoDB.Service;
using Moodle_with_MongoDB.WebModel;

namespace Moodle_with_MongoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var courses = _courseService.GetAll();
            return Ok(courses);
        }

        [HttpGet("getbyID")]
        public IActionResult GetByID([FromQuery] GetCourseByIDRequest request)
        {

            return Ok(_courseService.GetById((request)));

        }

        [HttpPost]
        public IActionResult Create(CreateCourseRequest request)
        {
            if (request == null)
            {
                return BadRequest("Request is null.");

            }
            _courseService.Create((request));
            return Ok();

        }

        [HttpDelete]
        public IActionResult Delete(DeleteCourseRequest request)
        {
            _courseService.Delete((request));
            return Ok();

        }

        [HttpGet("getbyName")]
        public IActionResult GetByName(GetCourseByNameRequest request)
        {
            var course = _courseService.GetByName(request);
            if (course == null)
            {
                return BadRequest();
            }
            return Ok(course);
        }
    }
}

