using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp109
{
    enum month
    {
        jan,
        feb,
        mar,
        apr,
        may
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The value of month jan is" + "enum is"  +(int)month.jan);
            Console.WriteLine("The value of month feb is" + "enum is" + (int)month.feb);
            Console.WriteLine("The value of month mar is" + "enum is" + (int)month.mar);
            Console.WriteLine("The valueof month apr is" + "enum is" + (int)month.apr);
            Console.WriteLine("THe value of month may is " + "enum is" + (int)month.may);
            Console.ReadLine();
        }
    }
}
