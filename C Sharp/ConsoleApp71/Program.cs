using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp71
{
    class employee
    {
        public int empid;
        public string name;
        public string job;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp1 = new employee();
            emp1.empid = 765;
            emp1.name = "Aditya";
            emp1.job = "Manager";
            Console.WriteLine("empid" + emp1.empid);
            Console.WriteLine( "name"+ emp1.name);
            Console.WriteLine("job" + emp1.job);
            Console.ReadLine();
        }
    }
}
