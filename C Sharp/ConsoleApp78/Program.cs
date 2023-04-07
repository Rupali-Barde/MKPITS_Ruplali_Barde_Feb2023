using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp78
{
    class employee
    {
        int empno;
        string empname;
        ~ employee()
        {
            Console.WriteLine("In destructor we write code to clean up operation like closing a file.");

           
        }
        public employee(int empno,string empname) { 
        this.empno = empno;
        this.empname = empname;
        }
        public void display()
        {
            Console.WriteLine("empno" + empno);
            Console.WriteLine("empname" + empname);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee(123, "rajesh");
            emp.display();
            Console.ReadLine();
        }
    }
}
