using MongoDB.Driver;
using Moodle_with_MongoDB.Model;
using Moodle_with_MongoDB.WebModel;
using System.Security.Cryptography;
using System.Text;

namespace Moodle_with_MongoDB.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(IMongoDatabase mongoDatabase) : base(mongoDatabase)
        {
        }
       public string EncryptPassword (EncryptPasswordRequest request)
        {
            using var sha256 = SHA256.Create();
            byte[] bytesPass = sha256.ComputeHash(Encoding.UTF8.GetBytes(request.Password));
            var sb = new StringBuilder();
            foreach (byte b in bytesPass) { sb.Append(b.ToString("x2")); }
            var salt = "tuthihongdiep";
            byte[] bytesSalt = sha256.ComputeHash(Encoding.UTF8.GetBytes(salt));
            foreach (byte b in bytesSalt) { sb.Append(b.ToString("x2")); }
            return sb.ToString();
        }
    }
}
