using Moodle_with_MongoDB.Model;
using Moodle_with_MongoDB.WebModel;

namespace Moodle_with_MongoDB.Service
{
    public class CourseService : ICourseService
    {
        public Course Create(CreateCourseRequest request)
        {
            return new Course { Name = request.Name, TeacherID = request.TeacherID };
        }

        public string Delete(DeleteCourseRequest request)
        {
            return request.ID.ToString();   
        }

        public string GetById(GetCourseByIDRequest request)
        {
            return request.CourseID.ToString(); 
        }
    }
}
