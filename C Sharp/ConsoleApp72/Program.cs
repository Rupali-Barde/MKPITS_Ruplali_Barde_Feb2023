using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp72
{
    class employee
    {
        public int empid;
        public string name;
        public string job;

        public void getdata()
        {
            empid = 456;
            name = "Anu";
            job = "Clerk";
        }
        public void displaydata()
        {
            Console.WriteLine("empid" + empid);
            Console.WriteLine("name" + name);
            Console.WriteLine("job" + job);
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                employee emp = new employee();
                emp.getdata();
                emp.displaydata();
                Console.ReadLine();
            }
        }
    }
}

