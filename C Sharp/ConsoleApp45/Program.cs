using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Addarr(arr);
            Console.ReadKey();
        }
        static void Addarr(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum = i + sum;

            }
            Console.WriteLine(sum);
        }
    }
}


