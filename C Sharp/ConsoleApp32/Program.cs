using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            for(i=1; i <= 20; i++)
            {
                if (i == 6)
                {
                    continue;

                }
                Console.WriteLine("Number ="+ i);
                Console.ReadLine();

            }


        }
    }
}
