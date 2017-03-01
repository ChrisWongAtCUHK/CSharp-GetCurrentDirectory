using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetCurrentDirectoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
            Console.ReadKey();
        }
    }
}
