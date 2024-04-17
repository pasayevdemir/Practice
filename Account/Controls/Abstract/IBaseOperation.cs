using Models;

namespace Account
{
    public interface IBaseOperation<T> where T : BaseEntity, new()
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(int id);
        List<T> GetAll();
        T GetById(int id);
    }
}
