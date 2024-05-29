using Moodle_with_MongoDB.Model;
using Moodle_with_MongoDB.WebModel;

namespace Moodle_with_MongoDB.Repository
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        void Create(CreateStudentRequest request);
        void Delete(DeleteStudentRequest request);    
        void Update(UpdateStudentRequest request);
    }
}
