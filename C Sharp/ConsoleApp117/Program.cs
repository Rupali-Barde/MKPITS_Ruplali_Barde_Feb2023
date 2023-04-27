using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp117
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            char[] ch = { 'c', 's', 'h', 'a', 'r', 'p' };
            string s2 = new string(ch);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.ReadLine();
        }
    }
}
