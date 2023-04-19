using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Enter Number");
            n1 = Convert.ToInt32(Console.ReadLine());
            table(n1);
            Console.ReadKey();

        }
        static int table(int num)
        {
            for(int j=1;j<=10;j++)
            {
                int mul = num * j;
                Console.WriteLine(mul);

            }
            return (num);

        }
        }
    }

