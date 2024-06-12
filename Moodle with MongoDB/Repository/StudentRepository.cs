using MongoDB.Driver;
using Moodle_with_MongoDB.Model;
using Moodle_with_MongoDB.WebModel;

namespace Moodle_with_MongoDB.Repository
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        //private readonly IMongoCollection<Student> _mongoStudentCollection;
        public StudentRepository(IMongoDatabase mongoDatabase) : base(mongoDatabase) 
        {

        }               

        public void Create(CreateStudentRequest request)
        {
            var newStudent = new Student { Name = request.Name, DOB = request.DOB, Address = request.Address };
            _collection.InsertOne(newStudent);
        }

        public void Delete(DeleteStudentRequest request)
        {
            var filter = Builders<Student>.Filter.Eq(s => s.ID, request.ID);
            //_mongoStudentCollection.DeleteOneAsync(filter);
            var deletedstudent = Builders<Student>.Update.Set(s =>s.IsDeleted, true);
            _collection.UpdateOne(filter, deletedstudent);
        }

        public List<Student> GetAll()
        {
            return _collection.Find(x => true).ToList();
        }

        public void Update(UpdateStudentRequest request)
        {
            var filter = Builders<Student>.Filter.Eq(s => s.ID, request.ID);
            var update = Builders<Student>.Update
                                            .Set(s => s.DOB, request.DOB)
                                            .Set(s => s.Address, request.Address);

            _collection.UpdateOne(filter, update);

        }
    }
}
