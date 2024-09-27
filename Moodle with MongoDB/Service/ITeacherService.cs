using Moodle_with_MongoDB.Model;
using Moodle_with_MongoDB.WebModel;

namespace Moodle_with_MongoDB.Service
{
    public interface ITeacherService
    {
        void Create(CreateTeacherRequest request);
        void Delete(DeleteTeacherRequest request);
        List<Teacher> GetAll();
        void Update(UpdateTeacherRequest request);
    }
}
