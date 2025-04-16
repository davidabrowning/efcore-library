using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Tests
{
    internal static class TestHelper
    {
        private static void PrintSuccess(string title)
        {
            Console.WriteLine($"Success: {title}");
        }
        private static void PrintFailure(string title, object expected, object actual)
        {
            Console.WriteLine($"Failure: {title} | Expected: {expected} | Actual: {actual}");
        }
        public static void AssertEquals(string title, object expected, object actual)
        {
            if (Equals(expected, actual))
                PrintSuccess(title);
            else
                PrintFailure(title, expected, actual);
        }
    }
}
