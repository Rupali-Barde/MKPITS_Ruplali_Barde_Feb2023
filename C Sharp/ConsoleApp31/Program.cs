using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            for(i=1;i<=10;i++)
            {
                if(i==5)
                {
                    break;
                }
                Console.WriteLine("Number =" + i);
                Console.ReadLine();
            }
        }
    }
}
