using Moodle_with_MongoDB.Model;
using Moodle_with_MongoDB.WebModel;

namespace Moodle_with_MongoDB.Service
{
    public interface ICourseService
    {
        void Create(CreateCourseRequest request);
        void Delete(DeleteCourseRequest request);
        List<Course> GetAll();
        Course GetById(GetCourseByIDRequest request);
        Course GetByName(GetCourseByNameRequest request);
        void Update(UpdateCourseRequest request);
    }
}
