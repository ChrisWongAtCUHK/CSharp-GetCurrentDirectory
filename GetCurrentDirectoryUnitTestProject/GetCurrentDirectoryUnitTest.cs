using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GetCurrentDirectoryUnitTestProject
{
    [TestClass]
    public class GetCurrentDirectoryUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
        }
    }
}
