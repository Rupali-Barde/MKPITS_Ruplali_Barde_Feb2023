using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp113
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 0;
            int res = 0;
            try
            {
                res = n1 / n2;
                Console.WriteLine("Res :" + res);
            }
            catch (DividedByZeroException ee) 
            {
                Console.WriteLine(ee.ToString());
            }
            Console.ReadLine();
        }
    }
}
