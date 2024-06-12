using MongoDB.Bson;
using MongoDB.Driver;

namespace Moodle_with_MongoDB.Repository
{

    public abstract class BaseRepository<T> where T : class
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
        public void Insert(T item)
        {
            _collection.InsertOne(item);

        }
        public void Delete(string id)
        {
            _collection.DeleteOne(id);
        }
        public T GetByID(string id)
        {
            var filter = Builders<T>.Filter.Eq("_id", ObjectId.Parse(id));
            return _collection.Find(filter).FirstOrDefault();
        }
        private object GetIdFromEntity(T entity)
        {
            var idProperty = entity.GetType().GetProperty("Id");
            if (idProperty != null)
            {
                return idProperty.GetValue(entity);
            }
            else
            {
                var idField = entity.GetType().GetField("_id");
                if (idField != null)
                {
                    return idField.GetValue(entity);
                }
                else
                {
                    throw new Exception("Entity must have an 'Id' property or '_id' field.");
                }
            }
        }







    }
}

