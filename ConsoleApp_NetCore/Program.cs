using System;
using ClassLibrary_NetStandard20;
using System.Text;

namespace ConsoleApp_NetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            var result = Class1.GetData();
            Console.Write(result);
        }
    }
}