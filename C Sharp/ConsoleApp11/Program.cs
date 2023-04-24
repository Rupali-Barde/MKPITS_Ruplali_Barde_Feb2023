using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            int num1, num2;
            Console.WriteLine("Enter num1");
            Console.WriteLine("Enter num2");
            num1=Convert.ToInt32(Console.ReadLine());   
            num2= Convert.ToInt32(Console.ReadLine());
            if (num1 > num2) {
                Console.WriteLine("Num 1 is greater");

            }
            else
            {
                Console.WriteLine("Num 2 is greater");
                Console.ReadLine();
            }
        }
    }
}
