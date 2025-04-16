using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLibrary.DataAccess
{
    public interface IRepository<T>
    {
        T Add(T entity);
        IEnumerable<T> GetAll();
        void SaveChanges();
        IEnumerable<T> DeleteAll();
    }
}
