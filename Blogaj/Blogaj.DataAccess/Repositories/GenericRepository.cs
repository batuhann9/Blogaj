using Microsoft.EntityFrameworkCore;
using Blogaj.DataAccess.Abstract;
using Blogaj.DataAccess.Context;
using System.Linq;
using System.Linq.Expressions;

namespace Blogaj.DataAccess.Repositories
{
    public class GenericRepository<T>(BlogajContext _context) : IRepository<T> where T : class
    {
        public DbSet<T> Table { get => _context.Set<T>();}
        public int Count()
        {
            return Table.Count();
        }

        public int Count(Expression<Func<T, bool>> predicate)
        {
            return Table.Count(predicate);
        }

        public void Create(T entity)
        {
            Table.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var entity = Table.Find(Id);

            Table.Remove(entity);
            _context.SaveChanges();
        }

        public T GetByFilter(Expression<Func<T, bool>> predicate)
        {
            return Table.Where(predicate).FirstOrDefault();
        }

        public T GetById(int Id)
        {
            return Table.Find(Id);
        }

        public List<T> GetFilteredList(Expression<Func<T, bool>> predicate)
        {
            return Table.Where(predicate).ToList();
        }

        public List<T> GetList()
        {
            return Table.ToList();
        }

        public void Update(T entity)
        {
            Table.Update(entity);
            _context.SaveChanges();
        }
    }
}
