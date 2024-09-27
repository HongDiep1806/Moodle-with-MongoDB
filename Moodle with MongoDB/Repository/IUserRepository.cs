using Moodle_with_MongoDB.Model;
using Moodle_with_MongoDB.WebModel;

namespace Moodle_with_MongoDB.Repository
{
    public interface IUserRepository : IBaseRepository<User>
    {
        string EncryptPassword(EncryptPasswordRequest request);
    }
}
   
