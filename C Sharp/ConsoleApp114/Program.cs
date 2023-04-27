using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp114
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 2;
            int res = 0;
            try
            {
                res = n1 / n2;
                Console.WriteLine("Result :" + res);
            }
            catch(DivideByZeroException ee)
            {
                Console.WriteLine(ee.ToString());
            }
            finally
            {
                Console.WriteLine("Finally Executed");
            }
            Console.WriteLine("Bye");
            Console.ReadLine();
          
        }
    }
}
