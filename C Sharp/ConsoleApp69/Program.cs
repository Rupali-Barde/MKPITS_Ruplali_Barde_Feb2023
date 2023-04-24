using ConsoleApp69;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp69

{
    class student
    {
        int rno;
        string name;
        public void getdata(int r,string n)
        {
            rno = r;
            name = n;
        }
        public void displaydata()
        {
            Console.WriteLine("rno" + rno);
            Console.WriteLine("name" + name);

        }



    }
}
    internal class Program
    {
        static void Main(string[] args)
        {
        student stud1 = new student();
        stud1.getdata(444, "Aditya");
        stud1.displaydata();
        Console.ReadLine();
        }
    }

