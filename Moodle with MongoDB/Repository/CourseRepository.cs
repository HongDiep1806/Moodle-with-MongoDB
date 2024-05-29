using MongoDB.Driver;
using Moodle_with_MongoDB.Model;
using Moodle_with_MongoDB.WebModel;

namespace Moodle_with_MongoDB.Repository
{
    public class CourseRepository : ICourseRepsitory
    {
        private readonly IMongoCollection<Course> _mongoCourseCollection;
        public CourseRepository(IMongoDatabase mongoDatabase)
        {
            _mongoCourseCollection = mongoDatabase.GetCollection<Course>("Courses");
        }
        public void Create(CreateCourseRequest request)
        {
            var newCourse = new Course { Name = request.Name, TeacherID = request.TeacherID};
            _mongoCourseCollection.InsertOne(newCourse);    
        }

        public void Delete(DeleteCourseRequest request)
        {
            var filter = Builders<Course>.Filter.Eq(s => s.ID, request.ID);
            var deletedCourse = Builders<Course>.Update.Set(s => s.IsDeleted, true);
            _mongoCourseCollection.UpdateOne(filter, deletedCourse);
        }

        public void Update(UpdateCourseRequest request)
        {
            var filter = Builders<Course>.Filter.Eq(s => s.ID, request.ID);
            var update = Builders<Course>.Update
                                            .Set(s => s.Name, request.Name)
                                            .Set(s => s.TeacherID, request.TeacherID);

            _mongoCourseCollection.UpdateOne(filter, update);
        }

        List<Course> ICourseRepsitory.GetAll()
        {
            return _mongoCourseCollection.Find(x => true).ToList();
        }
    }
}
