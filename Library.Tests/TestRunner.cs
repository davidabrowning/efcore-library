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

            Console.WriteLine("Running tests...");

            title = "Books count increases by 1 when book added to db";
            initialCount = dbCtx.Books.Count();
            dbCtx.Add(new Book() { Title = "TestBook" });
            dbCtx.SaveChanges();
            finalCount = dbCtx.Books.Count();
            TestHelper.AssertEquals(title, 1, finalCount - initialCount);

        }
    }
}
