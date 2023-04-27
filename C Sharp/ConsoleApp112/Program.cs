using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp112
{
    class Student
    {
        public int sid;
        public string name;
        public int age;
        public static string schoolName = "Boys High School";
        public Student(int sid, string name, int age)
        {
            this.sid = sid;
            this.name = name;
            this.age = age;
        }
        public void display()
        {
            Console.WriteLine("Student Id :" + sid);
            Console.WriteLine("Student Name :" + name);
            Console.WriteLine("Student Age :" + age);
            Console.WriteLine("School Name :" + schoolName);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(11, "Aarav", 12);
            Student s2 = new Student(23, "PAras", 13);
            s1.display();
            s2.display();
            Console.ReadLine();
        }
    }
}
