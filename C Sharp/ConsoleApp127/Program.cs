using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp127
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello F#";
            string s2 = s1.Replace('F', 'C');
            Console.WriteLine(s2);
            Console.ReadLine();
        }
    }
}
