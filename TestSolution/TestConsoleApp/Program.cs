using System;
using TestLibrary;

namespace TestConsoleApp
{
    class Program
    {
        static void Main()
        {
            TestClass a = new TestClass();
            Console.WriteLine(a.CurrentDate());
        }
    }
}
