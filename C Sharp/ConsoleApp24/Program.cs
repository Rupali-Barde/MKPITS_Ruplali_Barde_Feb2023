using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int num1, num2, result;
            Console.WriteLine("Enter number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Calling addition function");
            result = addition(num1, num2);
            Console.WriteLine("addition =" + result);
            Console.WriteLine("Calling subtraction function");
            result = subtraction(num1, num2);
            Console.WriteLine("subtraction =" + result);
            Console.ReadLine();
        }
        static int addition(int num1, int num2)
        {
            int result=num1 + num2;
            return result;
        }
        static int subtraction(int num1, int num2)
        {
            int result=num1 - num2;
            return result;
        }
    }
}

