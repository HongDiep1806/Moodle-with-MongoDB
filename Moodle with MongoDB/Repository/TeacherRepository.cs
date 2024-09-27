using MongoDB.Driver;
using Moodle_with_MongoDB.Model;
using Moodle_with_MongoDB.WebModel;

namespace Moodle_with_MongoDB.Repository
{
    public class TeacherRepository : BaseRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(IMongoDatabase mongoDatabase) : base(mongoDatabase) 
        {

        }               

    }
}
