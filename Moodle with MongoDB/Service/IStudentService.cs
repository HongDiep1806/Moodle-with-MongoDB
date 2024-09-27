using Moodle_with_MongoDB.Model;
using Moodle_with_MongoDB.WebModel;

namespace Moodle_with_MongoDB.Service
{
    public interface IStudentService
    {
        void Create(CreateStudentRequest request);
        void Delete(DeleteStudentRequest request);
        List<Student> GetAll();
        void Update(UpdateStudentRequest request);
    }
}
