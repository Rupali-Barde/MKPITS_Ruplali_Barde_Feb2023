using ConsoleApp106;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp106
{
    public static class Calculate
    {
        public static int n;
        public static float pi = 3.14f;
        public static int cube(int n)
        {
            return n* n * n;
        }
    }


internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("pi =" + Calculate.pi);
        Console.WriteLine("Cube =" + Calculate.cube(3));
        Console.ReadLine();
    }
   
}
}



