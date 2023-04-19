using ConsoleApp88;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp88
{
    public class Person
    {
        string name;
        string address;
        public void getPersonData(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void displayPersonData()
        {
            Console.WriteLine("name :" + name);
            Console.WriteLine("address :"+ address);
        }
    }
    public class student : Person
    {
        int rno;
        int marks;
        public void getStudentData(int rno, int marks)
        {
            this.rno = rno;
            this.marks = marks;
        }
        public void displayStudentData()
        {
            Console.WriteLine("rno :" + rno);
            Console.WriteLine("marks :" + marks);

        }
    }
    public class Employee : Person
    {
        int salary;
        string designation;
        public void getEmployeeData(int salary, string designation)
        {
            this.salary = salary;
            this.designation = designation;
        }
            public void displayEmployeeData()
            {
            Console.WriteLine("salary :" + salary);
            Console.WriteLine("designation :" + designation);
            }
        

        }
        }

    
    internal class Program
    {
        static void Main(string[] args)
        {
        student p1 = new student();
        p1.getPersonData("Rupali", "Nagpur");
        p1.getStudentData(111, 999);
        p1.displayPersonData();
        p1.displayStudentData();

        Employee e1 = new Employee();
        e1.getPersonData("Radha", "Nagpur");
        e1.getEmployeeData(9999, "Manager");
        e1.displayPersonData();
        e1.displayEmployeeData();
        Console.ReadLine();

        }
    }
 
