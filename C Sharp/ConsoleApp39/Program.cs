using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total;
            total = calculate(3, 5, 7, 9, 11);
            Console.WriteLine("Total =" + total);
            Console.ReadLine();
        }
        static int calculate(params int[] val)
        {
            int counter, total = 0;
            for (counter = 0; counter < val.Length; counter++)
            {
                total = total + val[counter];
            }
            return total;
        }
            
    }
}
