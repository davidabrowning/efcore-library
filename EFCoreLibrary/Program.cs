using EFCoreLibrary.DataAccess;
using Library.Tests;

namespace EFCoreLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestRunner testRunner = new TestRunner();
            testRunner.RunTests();
        }
    }
}
