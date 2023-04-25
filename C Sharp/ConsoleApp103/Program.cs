using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp103
{ 
    class Employee
{
    public int empno;
    public string name;
    public  static string companyname = "Wipro";
    public Employee (int empno, string name)
    {
        this.empno = empno;
        this.name = name;
    }
    public void display()
    {
        Console.WriteLine("EmpNo :" + empno);
        Console.WriteLine("Name :" + name);
        Console.WriteLine("Company Name :" + companyname);
    }

}
    internal class Program
    {
        static void Main(string[] args)
        {
        Employee e1 = new Employee(567, "Aditya");
        Employee e2 = new Employee(79, "Gopal");

        e1.display();
        e2.display();
        Console.ReadLine();
        }
    }
}
