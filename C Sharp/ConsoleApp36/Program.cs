using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine("Value of num inside main before passng" + num);
            display(num);
            Console.WriteLine("Value of num after callinng" + num);

        }
        
            static void display(int num)
        {
            num = num + 2;
            Console.WriteLine("Value of num inside dispaly" + num);
            Console.ReadLine();
        }
       
    }
}
