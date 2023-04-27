using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 = "llo";
            string s3 = "C#";
            Console.WriteLine(s1.EndsWith(s2));
            Console.WriteLine(s1.EndsWith(s3));
            Console.ReadLine();
        }
    }
}
