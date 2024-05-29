using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moodle_with_MongoDB.Repository;
using Moodle_with_MongoDB.WebModel;

namespace Moodle_with_MongoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepsitory _courseRepository;
        public CourseController(ICourseRepsitory courseRepository)
        {
            _courseRepository = courseRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var courses = _courseRepository.GetAll();
            return Ok(courses);
        }

        [HttpPost]
        public IActionResult Create(CreateCourseRequest request)
        {
            _courseRepository.Create(request);
            return Ok();

        }

        [HttpDelete]
        public IActionResult Delete(DeleteCourseRequest request)
        {
            _courseRepository.Delete(request);
            return Ok();

        }

        [HttpPut]
        public IActionResult Update(UpdateCourseRequest request)
        {
            _courseRepository.Update(request);
            return Ok();
        }
    }
}

