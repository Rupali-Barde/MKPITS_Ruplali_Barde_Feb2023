using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp87
{
    public class Person
    {
        string name;
        string address;
        public void getpersonData(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public void displaypersonData()
        {
            Console.WriteLine("name :" + name);
            Console.WriteLine("address :" + address);

        }
    }
    public class Employee : Person
    {
        string designation;
        int salary;
        public void getEmployeeData(string designation, int salary)
        {
            this.designation = designation;
            this.salary = salary;
        }
        public void displayemployeeData()
        {
            Console.WriteLine("Dseignation :" + designation);
            Console.WriteLine("Salary :" + salary);
        }

    }
    public class PartTimeEmployee : Employee
    {
        int no_of_hours;
        public void getParttimeEmployeeData(int no_of_hours)
        {
            this.no_of_hours = no_of_hours;
        }
        public void displayparttimeEmployeeData()
        {
            Console.WriteLine("no_of_hours :" + no_of_hours);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployee p1 = new PartTimeEmployee();
            p1.getpersonData("Amit", "Nagpur");
            p1.getEmployeeData("Clerk", 11100);
            p1.getParttimeEmployeeData(5);
            p1.displaypersonData();
            p1.displayemployeeData();
            p1.displayparttimeEmployeeData();
            Console.ReadLine();
        }
    }
}
