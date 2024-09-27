using Moodle_with_MongoDB.Model;
using Moodle_with_MongoDB.WebModel;

namespace Moodle_with_MongoDB.Service
{
    public interface IUserService
    {
        void Create(CreateUserRequest request);
        //void Delete(DeleteTeacherRequest request);
        List<User> GetAll();
        //void Update(UpdateTeacherRequest request);
        string EncryptPassword (EncryptPasswordRequest request);
    }
}
