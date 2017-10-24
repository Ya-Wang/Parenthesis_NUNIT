using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EGifter_ParenthesisExtension;
using EGifter_Parenthesis.Tests;

namespace DllDebugger
{
    class Program
    {
        static void Main(string[] args)
        {
            // since this console application is around I can put the test case here
            new Parenthesis_Test().TestValues();
            // end test 
            Console.WriteLine("Enter the string: \n");
            string entryStr;
            entryStr = Console.ReadLine();
            Console.WriteLine(entryStr.IsClosed());
            Console.Read();
        }
    }
}
