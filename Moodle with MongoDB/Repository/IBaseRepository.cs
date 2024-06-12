using System.Linq.Expressions;

namespace Moodle_with_MongoDB.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        void Create(T entity);
        void Delete(string id);
        List<T> GetAll();
        T GetByID(string id);
    }
}
