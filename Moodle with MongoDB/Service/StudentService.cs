using Moodle_with_MongoDB.Model;
using Moodle_with_MongoDB.Repository;
using Moodle_with_MongoDB.WebModel;

namespace Moodle_with_MongoDB.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public void Create(CreateStudentRequest request)
        {
            _studentRepository.Create(new Student() { IRN = request.IRN,Name=request.Name,DOB=request.DOB,Address= request.Address});
        }

        public void Delete(DeleteStudentRequest request)
        {
            _studentRepository.Delete(request.ID);
        }

        public List<Student> GetAll()
        {
           return _studentRepository.GetAll();
        }

        public void Update(UpdateStudentRequest request)
        {
            _studentRepository.Update(request.ID, new Student() { IRN = request.IRN, Name = request.Name, DOB = request.DOB, Address = request.Address });
        }
    }
}
