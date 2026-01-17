using System.Linq.Expressions;

namespace Blogaj.DataAccess.Abstract
{
    public interface IRepository<T> where T : class
    {
        List<T> GetList();
        T GetByFilter(Expression<Func<T, bool>> predicate);
        T GetById(int Id);
        void Create(T entity);
        void Update(T entity);
        void Delete(int Id);
        int Count();
        int Count(Expression<Func<T, bool>> predicate);
        List<T> GetFilteredList(Expression<Func<T, bool>> predicate);
    }
}
