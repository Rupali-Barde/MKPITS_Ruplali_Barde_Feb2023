using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Check
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter num");
            num=Convert.ToInt32(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
            Console.ReadLine();
        }
    }
}
