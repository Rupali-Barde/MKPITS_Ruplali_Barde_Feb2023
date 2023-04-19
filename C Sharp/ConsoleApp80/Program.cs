using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp80
{
    class person
    {
        public string name;
        public string address;
    }
    class employee : person
    {
        public int empno;
        public int salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.empno = 123;
            emp.name = "Aditya";
            emp.address = "Nagpur";
            emp.salary = 12345;
            Console.WriteLine("empno :" + emp.empno);
            Console.WriteLine("empname :" + emp.name);
            Console.WriteLine("empaddress :" + emp.address);
            Console.WriteLine("empsalary :" + emp.salary);
            Console.ReadLine();

        }
    }
}
