using Moodle_with_MongoDB.Model;
using Moodle_with_MongoDB.Repository;
using Moodle_with_MongoDB.WebModel;

namespace Moodle_with_MongoDB.Service
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepsitory _courseRepository;
        public CourseService(ICourseRepsitory courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public void Create(CreateCourseRequest request)
        {

            _courseRepository.Create(new Course() { TeacherID = request.TeacherID, Name = request.Name });

        }

        public void Delete(DeleteCourseRequest request)
        {
            _courseRepository.Delete(request.ID);
        }

        public List<Course> GetAll()
        {
            return _courseRepository.GetAll();
        }

        public Course GetById(GetCourseByIDRequest request)
        {
            return _courseRepository.GetByID(request.CourseID);
        }

        public Course GetByName(GetCourseByNameRequest request)
        {
            return _courseRepository.GetCourseByName(request.CourseName);
        }


    }
}
