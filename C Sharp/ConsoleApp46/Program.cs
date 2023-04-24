using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;
            double square;
            Console.WriteLine("Enter any number");
            num=Convert.ToDouble(Console.ReadLine());
            square = num * num;
            Console.WriteLine("Square =" + square);
            Console.ReadLine();

        }
        public static double GetSquare(double num)
        {
            return num * num;
        }
    }
}
