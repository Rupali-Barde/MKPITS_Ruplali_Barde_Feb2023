﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculate();
        }
        static void calculate()
        {
            int num1, num2, result;
            Console.WriteLine("Entre num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Calling addition function");
            result = addition(num1, num2);
            Console.WriteLine("addition =" + result);

            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Calling subtraction function");
            result = addition(num1, num2);
            Console.WriteLine("subtraction =" + result);
            Console.ReadLine();
        }
        static int addition(int num1, int num2)
        {
            int result= num1 + num2;
            return result;
        }
        static int subtraction(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }

    }
}

