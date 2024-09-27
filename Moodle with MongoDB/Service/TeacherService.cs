using Moodle_with_MongoDB.Model;
using Moodle_with_MongoDB.Repository;
using Moodle_with_MongoDB.WebModel;

namespace Moodle_with_MongoDB.Service
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        public void Create(CreateTeacherRequest request)
        {
           _teacherRepository.Create(new Teacher() { Name = request.Name, DOB = request.DOB, Address = request.Address});
        }

        public void Delete(DeleteTeacherRequest request)
        {
            _teacherRepository.Delete(request.ID);
        }

        public List<Teacher> GetAll()
        {
           return _teacherRepository.GetAll();
        }

        public void Update(UpdateTeacherRequest request)
        {
            _teacherRepository.Update(request.ID, new Teacher() { Name = request.Name, DOB = request.DOB, Address = request.Address });
        }
    }
}
