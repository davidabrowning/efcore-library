using EFCoreLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Tests
{
    public class MemberRepository : GenericRepository<Member>
    {
        public MemberRepository(LibraryDbContext dbCtx) : base(dbCtx)
        {

        }
    }
}
