using EFCoreLibrary.DataAccess;
using Library.Tests;

namespace EFCoreLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //LibraryDbContext dbCtx = new LibraryDbContext();
            //Book myBook = new Book()
            //{
            //    Title = "The Power Broker"
            //};
            //dbCtx.Books.Add(myBook);
            //dbCtx.SaveChanges();
            //Console.WriteLine("Book saved");
            TestRunner testRunner = new TestRunner();
            testRunner.RunTests();
        }
    }
}
