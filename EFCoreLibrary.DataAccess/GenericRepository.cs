using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLibrary.DataAccess
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly LibraryDbContext _dbCtx;
        public GenericRepository(LibraryDbContext dbCtx)
        {
            _dbCtx = dbCtx;
        }
        public T Add(T entity)
        {
            _dbCtx.Add(entity);
            return entity;
        }
        public IEnumerable<T> GetAll()
        {
            return _dbCtx.Set<T>().ToList();
        }
        public void SaveChanges()
        {
            _dbCtx.SaveChanges();
        }
    }
}
