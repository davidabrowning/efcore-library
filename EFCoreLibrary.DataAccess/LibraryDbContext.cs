using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLibrary.DataAccess
{
    public class LibraryDbContext : DbContext
    {
        private string connectionStringTestDb = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LibraryTest;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        private string connectionStringProdDb = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LibraryProd;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionStringTestDb);
        }
    }
}
