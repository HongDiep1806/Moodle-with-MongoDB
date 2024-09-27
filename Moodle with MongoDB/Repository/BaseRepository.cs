using MongoDB.Bson;
using MongoDB.Driver;

namespace Moodle_with_MongoDB.Repository
{

    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public readonly IMongoCollection<T> _collection;
        public BaseRepository(IMongoDatabase mongoDatabase)
        {
            _collection = mongoDatabase.GetCollection<T>(typeof(T).Name);
        }
        public List<T> GetAll()
        {
            return _collection.AsQueryable().ToList();
        }

        public void Delete(string id)
        {
            var filter = Builders<T>.Filter.Eq("_id", ObjectId.Parse(id));
            _collection.DeleteOne(filter);
        }
        public T GetByID(string id)
        {
            var filter = Builders<T>.Filter.Eq("_id", ObjectId.Parse(id));
            return _collection.Find(filter).FirstOrDefault();
        }


        public void Create(T entity)
        {
            _collection.InsertOne(entity);
        }
        public void Update(string id,T entity)
        {
            var filter = Builders<T>.Filter.Eq("_id", ObjectId.Parse(id));
            _collection.ReplaceOne(filter, entity);
        }
    }

    }


