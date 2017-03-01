using System;
using NUnit.Framework;

namespace GetCurrentDirectoryClassLibrary
{
    [TestFixture]
    class GetCurrentDirectoryTest
    {
        [Test]
        public void NUnitTest()
        {
            Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
        }
    }
}
