using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 3, 5, 1, 4, 8 };
            Array.Clear(num, 0, 2);
            for (int i = 0; i < num.Length; i++) 
            {
                Console.WriteLine(num[i] + " \t");
            }
            Console.ReadLine();
        }
    }
}
