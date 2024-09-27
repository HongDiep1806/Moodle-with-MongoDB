using Moodle_with_MongoDB.Model;
using Moodle_with_MongoDB.Repository;
using Moodle_with_MongoDB.WebModel;

namespace Moodle_with_MongoDB.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void Create(CreateUserRequest request)
        {
            var encryptedPassword = EncryptPassword( new EncryptPasswordRequest() { Password = request.Password });
           _userRepository.Create(new User() { IRN = request.IRN, Name=request.Name, Password=encryptedPassword,
                                               Address=request.Address,Avatar = request.Avatar,DOB=request.DOB,
                                               UserType=request.UserType}); 
        }

        public string EncryptPassword(EncryptPasswordRequest request)
        {
           return _userRepository.EncryptPassword(request);
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }
    }
}
