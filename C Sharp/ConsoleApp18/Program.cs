using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Operator
    {
        static void Main(string[] args)
        {
            int num1, num2;
            char op;
            int res = 0;
            Console.WriteLine("Enter num1");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
            num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operator like +,-,*");
            op=Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                case '+':
                    res = num1 + num2;
                    break;
                case '-':
                    res = num1 - num2;
                    break;
                case '*':
                    res = num1 * num2;
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
            Console.WriteLine("Result =" + res);
            Console.ReadLine();
        }
    }
}
