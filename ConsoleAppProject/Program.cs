//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{

    public class Program
    {
        static int sum(int a, int b)
        {
            return (a + b);
        }
        public static void Main(string[] args)
        {
            //Your code goes here

            int a = 12;
            int b = 13;
            string sumResult = sum(a, b).ToString();

            Console.WriteLine(sumResult);
        }
    }
}