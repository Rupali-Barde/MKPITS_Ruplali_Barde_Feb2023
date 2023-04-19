using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp70
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
    internal class Program
    {
        static void Main(string[] args)
        {
            student stud1 = new student();
            Console.WriteLine("Enter rno");
            int rno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            stud1.getdata(rno, name);
            stud1.displaydata();
            Console.ReadLine(); 
        }
    }
}
