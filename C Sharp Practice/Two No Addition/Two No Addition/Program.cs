﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_No_Addition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

           
           Console.WriteLine("Enter the second number: ");
           int number2 = Convert.ToInt32(Console.ReadLine());


            int sum = number1 + number2;

            Console.WriteLine("The sum of {0} and {1} is {2}.", number1, number2, sum);

        }
    }
}
