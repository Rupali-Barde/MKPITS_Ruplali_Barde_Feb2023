using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Greatest
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter num1");
            Console.WriteLine("Enter num2");
            Console.WriteLine("Enter num3");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2) 
            {
                Console.WriteLine("num 1 is greater");
            }
            else if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine("num 2 is greater");
            }
            else
            {
                Console.WriteLine("num 3 is greater");

            }
            Console.ReadLine();
        }
    }
}
