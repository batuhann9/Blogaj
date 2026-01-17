using System.Linq.Expressions;

namespace Blogaj.Business.Abstract
{
    public interface IGenericService<T> where T : class
    {
        List<T> TGetList();
        T TGetByFilter(Expression<Func<T, bool>> predicate);
        T TGetById(int Id);
        void TCreate(T entity);
        void TUpdate(T entity);
        void TDelete(int Id);
        int TCount();
        int TCount(Expression<Func<T, bool>> predicate);
        List<T> TGetFilteredList(Expression<Func<T, bool>> predicate);
    }
}

