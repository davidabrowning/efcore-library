using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLibrary.DataAccess
{
    public class BookRepository : GenericRepository<Book>
    {
        public BookRepository(LibraryDbContext dbCtx) : base(dbCtx)
        {
        }
    }
}
