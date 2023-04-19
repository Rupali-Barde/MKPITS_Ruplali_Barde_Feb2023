using ConsoleApp73;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp73
{
    class employee
    {
        int empid;
        string name;
        string job;
        public void getdata(int id, string n, string j)
        {
            empid = id;
            name = n;
            job = j;
        }
        public void displaydata()
        {
            Console.WriteLine("empid" + empid);
            Console.WriteLine("name" + name);
            Console.WriteLine("job" + job);
        }




    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp1 = new employee();
            emp1.getdata(786, "Gopal", "Clerk");
            emp1.displaydata();
            Console.ReadLine();
        }
    }
}


