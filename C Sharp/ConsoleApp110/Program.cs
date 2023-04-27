using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp110
{
    sealed class Employee
    {
        public void showdata()
        {
            Console.WriteLine("Hello");

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.showdata();
            Console.ReadLine();
        }
    }
}
