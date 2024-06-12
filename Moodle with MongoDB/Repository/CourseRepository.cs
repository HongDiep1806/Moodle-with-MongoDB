using MongoDB.Bson.IO;
using MongoDB.Driver;
using Moodle_with_MongoDB.Model;
using Moodle_with_MongoDB.WebModel;

namespace Moodle_with_MongoDB.Repository
{
    public class CourseRepository : BaseRepository<Course>, ICourseRepsitory
    {
        public CourseRepository(IMongoDatabase mongoDatabase) : base(mongoDatabase)
        {
            
        }

        public Course GetCourseByName(string courseName)
        {
            var filter = Builders<Course>.Filter.Eq(c => c.Name, courseName);
            var course = _collection.Find(filter).FirstOrDefault();

            return course;
        }
    }
}
