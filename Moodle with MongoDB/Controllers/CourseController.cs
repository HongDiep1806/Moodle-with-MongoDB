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
        //private readonly CourseRepository courseRepository;
        private readonly ICourseRepsitory _courseRepository;
        //private readonly ICourseService _courseService;  
        public CourseController(ICourseRepsitory _courserepository )
        {
            _courseRepository = _courserepository;
            //courseRepository = courserepository;
            //_courseService = _courseservice;

        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var courses = _courseRepository.GetAll();
            return Ok(courses);
        }

        [HttpGet("getbyID")]
        public IActionResult GetByID([FromQuery] GetCourseByIDRequest request)
        {

            return Ok(_courseRepository.GetByID((request)));

        }

        [HttpPost]
        public IActionResult Create(CreateCourseRequest request)
        {
            if (request == null)
            {
                return BadRequest("Request is null.");

            }
            _courseRepository.Create((request));
            return Ok();

        }

        [HttpDelete]
        public IActionResult Delete(DeleteCourseRequest request)
        {
            _courseRepository.Delete((request));
            return Ok();

        }

        [HttpGet("getbyName")]
        public IActionResult GetByName([FromQuery] string name)
        {
            var course = _courseRepository.GetCourseByName(name);
            if (course == null)
            {
                return BadRequest();
            }
            return Ok(course);
        }
    }
}

