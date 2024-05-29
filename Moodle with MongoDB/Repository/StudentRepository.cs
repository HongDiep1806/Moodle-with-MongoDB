using MongoDB.Driver;
using Moodle_with_MongoDB.Model;
using Moodle_with_MongoDB.WebModel;

namespace Moodle_with_MongoDB.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IMongoCollection<Student> _mongoStudentCollection;
        public StudentRepository(IMongoDatabase mongoDatabase)
        {
            _mongoStudentCollection = mongoDatabase.GetCollection<Student>("Students");
        }

        public void Create(CreateStudentRequest request)
        {
            var newStudent = new Student { Name = request.Name, DOB = request.DOB, Address = request.Address };
            _mongoStudentCollection.InsertOne(newStudent);
        }

        public void Delete(DeleteStudentRequest request)
        {
            var filter = Builders<Student>.Filter.Eq(s => s.ID, request.ID);
            //_mongoStudentCollection.DeleteOneAsync(filter);
            var deletedstudent = Builders<Student>.Update.Set(s =>s.IsDeleted, true);
            _mongoStudentCollection.UpdateOne(filter, deletedstudent);
        }

        public List<Student> GetAll()
        {
            return _mongoStudentCollection.Find(x => true).ToList();
        }

        public void Update(UpdateStudentRequest request)
        {
            var filter = Builders<Student>.Filter.Eq(s => s.ID, request.ID);
            var update = Builders<Student>.Update
                                            .Set(s => s.DOB, request.DOB)
                                            .Set(s => s.Address, request.Address);

            _mongoStudentCollection.UpdateOne(filter, update);

        }
    }
}
