using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp118
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "hello2";
            int res = string.Compare(s1, s2);
            if(res == 0)
            {
                Console.WriteLine("Both String Are Equal");
            }
            else if(res == 1)
            {
                Console.WriteLine("First String Is Greater");
            }
            else
            {
                Console.WriteLine("Second String Is Greater");
            }
            Console.ReadLine();
        }
    }
}
