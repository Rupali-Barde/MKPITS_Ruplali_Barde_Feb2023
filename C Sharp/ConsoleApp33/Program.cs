using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2,result=0;
            char op;
            Console.WriteLine("Enter two numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter +,-,*");
            op= Convert.ToChar(Console.ReadLine());
            if(op == '+')
            {
                goto addition;

            }
            else if(op == '-')

                {
                goto subtraction;

            }
            else
            {
                goto end;
            }
        addition:
           result = num1 + num2;
            goto  end;
            subtraction:
            result= num1 - num2;        
            goto end;
        end:
            Console.WriteLine("Result =" + result);
            Console.ReadKey();




        }
    }
}
