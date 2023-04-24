using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Age
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter Age");
            age=Convert.ToInt32 (Console.ReadLine());
            if(age<18)
            {
                Console.WriteLine("Not Eligible For Vote");
            }
            else
            {
                Console.WriteLine("Eligible For Vote");
                Console.ReadLine();

            }
        }
    }
}
