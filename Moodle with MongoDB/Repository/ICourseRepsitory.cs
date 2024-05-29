using Moodle_with_MongoDB.Model;
using Moodle_with_MongoDB.WebModel;

namespace Moodle_with_MongoDB.Repository
{
    public interface ICourseRepsitory
    {
        List<Course> GetAll();
        void Create(CreateCourseRequest request);
        void Update(UpdateCourseRequest request);
        void Delete(DeleteCourseRequest request);
    }
}
