using Moodle_with_MongoDB.Model;
using Moodle_with_MongoDB.WebModel;

namespace Moodle_with_MongoDB.Service
{
    public interface ICourseService
    {
        Course Create(CreateCourseRequest request);
        string Delete(DeleteCourseRequest request); 
        string GetById(GetCourseByIDRequest request);   

    }
}
