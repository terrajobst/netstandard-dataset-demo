using System;
using ClassLibrary_NetStandard20;

namespace ConsoleApp_NetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Class1.GetData();
            Console.Write(result);
        }
    }
}