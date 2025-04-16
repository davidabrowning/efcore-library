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
            IRepository<Book> bookRepository = new BookRepository(dbCtx);
            IRepository<Member> memberRepository = new MemberRepository(dbCtx);

            TestPrep(bookRepository);

            title = "Books count is initially 0";
            finalCount = bookRepository.GetAll().Count();
            TestHelper.AssertEquals(title, 0, finalCount);

            title = "Books count increases by 1 when book added to db";
            initialCount = bookRepository.GetAll().Count();
            bookRepository.Add(new Book() { Title = "TestBook" });
            bookRepository.SaveChanges();
            finalCount = bookRepository.GetAll().Count();
            TestHelper.AssertEquals(title, 1, finalCount - initialCount);

            title = "Members count increases by 1 when member added to db";
            initialCount = memberRepository.GetAll().Count();
            memberRepository.Add(new Member() { EmailAddress = "test@test.com" });
            memberRepository.SaveChanges();
            finalCount = memberRepository.GetAll().Count();
            TestHelper.AssertEquals(title, 1, finalCount - initialCount);

        }
        private void TestPrep<T>(IRepository<T> repository)
        {
            repository.DeleteAll();
            repository.SaveChanges();
        }
    }
}
