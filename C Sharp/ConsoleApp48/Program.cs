using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, count = 1, num;
            Console.WriteLine("Enter Number Of Rows");
            num = int.Parse(Console.ReadLine());
            count = num - 1;
            for (j = 1; j <= num; j++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                for (i = 1; i <= 2 * j - 1; i++)
                    Console.Write(" * ");
                Console.WriteLine();

               
            }

            count = 1;
            for (j = 1; j <= num; j++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count++;
                for (i = 1; i <= 2 * (num - j) - 1; i++)
                    Console.Write(" * ");
                Console.WriteLine();

            }

            Console.ReadLine();
            }
        }
    
}
