using EFCoreLibrary.DataAccess;

namespace Library.Tests
{
    public class TestRunner
    {
        public void RunTests()
        {
            string title;
            int initialCount, finalCount;
            LibraryDbContext dbCtx = new LibraryDbContext();
            BookRepository bookRepository = new BookRepository(dbCtx);

            Console.WriteLine("Running tests...");

            title = "Books count is not initially 0";
            finalCount = bookRepository.GetAll().Count();
            TestHelper.AssertNotEquals(title, 0, finalCount);

            title = "Books count increases by 1 when book added to db";
            initialCount = bookRepository.GetAll().Count();
            bookRepository.Add(new Book() { Title = "TestBook" });
            bookRepository.SaveChanges();
            finalCount = bookRepository.GetAll().Count();
            TestHelper.AssertEquals(title, 1, finalCount - initialCount);

        }
    }
}
