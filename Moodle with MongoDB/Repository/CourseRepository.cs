using MongoDB.Bson.IO;
using MongoDB.Driver;
using Moodle_with_MongoDB.Model;
using Moodle_with_MongoDB.WebModel;

namespace Moodle_with_MongoDB.Repository
{
    public class CourseRepository : BaseRepository<Course>, ICourseRepsitory
    {
        //private readonly IMongoCollection<Course> _mongoCourseCollection;
        public CourseRepository(IMongoDatabase mongoDatabase) : base(mongoDatabase)
        {
            
        }


        public void Create(CreateCourseRequest request)
        {
            var newCourse = new Course { Name = request.Name, TeacherID = request.TeacherID };
            base.Insert(newCourse);
        }

        public void Delete(DeleteCourseRequest request)
        {
            base.Delete(request.ID);
        }

        public void Update(UpdateCourseRequest request)
        {
            var filter = Builders<Course>.Filter.Eq(s => s.ID, request.ID);
            var update = Builders<Course>.Update
                                         .Set(s => s.Name, request.Name)
                                         .Set(s => s.TeacherID, request.TeacherID);

            _collection.UpdateOne(filter, update);
        }


        public List<Course> GetAll()
        {
            return base.GetAll();
        }

        public Course GetByID(GetCourseByIDRequest request)
        {
            return base.GetByID(request.CourseID);
        }

        public Course GetCourseByName(string courseName)
        {
            var filter = Builders<Course>.Filter.Eq(c => c.Name, courseName);
            var course = _collection.Find(filter).FirstOrDefault();

            return course;
        }
    }
}
