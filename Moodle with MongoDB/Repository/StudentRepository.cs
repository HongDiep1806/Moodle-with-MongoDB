using MongoDB.Driver;
using Moodle_with_MongoDB.Model;
using Moodle_with_MongoDB.WebModel;

namespace Moodle_with_MongoDB.Repository
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(IMongoDatabase mongoDatabase) : base(mongoDatabase)
        {

        }
        
    }
}
