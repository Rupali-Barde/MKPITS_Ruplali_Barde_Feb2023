using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
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
            if (op == '+')
            {
                res = num1 + num2;
            }
           else if
                
                (op == '-')
            { 
                    res= num1 - num2;
            }
            else if
                (op == '*')
            { 
                    res= num1 * num2;
            }
            else
            {
                Console.WriteLine("Invalid Operator");
                Console.WriteLine("Result =" + res);
                Console.ReadLine();
                

            }
            
        }
    }
}
