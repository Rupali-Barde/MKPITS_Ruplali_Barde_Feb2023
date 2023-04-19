using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 20;
            arr[1] = 30;
            arr[2] = 50;
            arr[3] = 100;
            arr[4] = 200;
            foreach(int val in arr)
            {
                Console.WriteLine("integer = " +val);
            }
            Console.ReadLine();

        }
    }
}
