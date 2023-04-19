using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 2, 4, 6, 9, 1 };
            int[] num1 = (int[])num.Clone();
            for(int i=0; i<num1.Length; i++)
            {
                Console.WriteLine(num[i] + "\t");
            }
            Console.ReadLine();
        }
    }
}
