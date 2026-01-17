using Blogaj.Business.Abstract;
using Blogaj.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blogaj.Business.Concrete
{
    public class GenericManager<T>(IRepository<T> _repository) : IGenericService<T> where T : class
    {
        public int TCount()
        {
            return _repository.Count();
        }

        public int TCount(Expression<Func<T, bool>> predicate)
        {
            return _repository.Count(predicate);
        }

        public void TCreate(T entity)
        {
            _repository.Create(entity);
        }

        public void TDelete(int Id)
        {
            _repository.Delete(Id);
        }

        public T TGetByFilter(Expression<Func<T, bool>> predicate)
        {
            return _repository.GetByFilter(predicate);
        }

        public T TGetById(int Id)
        {
            return _repository.GetById(Id);
        }

        public List<T> TGetFilteredList(Expression<Func<T, bool>> predicate)
        {
            return _repository.GetFilteredList(predicate);
        }

        public List<T> TGetList()
        {
            return _repository.GetList();
        }

        public void TUpdate(T entity)
        {
            _repository.Update(entity);
        }

    }
}
