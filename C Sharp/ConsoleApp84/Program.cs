using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp84
{
    class person
    {
        string name;
        string address;
        double mobileno;
        public void getdata(string name,string address,double mobileno)
        {
            this.name = name;
            this.address = address;
            this.mobileno = mobileno;
        }
        public void display ()
        {
            Console.WriteLine(name);
            Console.WriteLine(address);
            Console.WriteLine(mobileno);
        }
    }  
    class student : person
    {
        int rno;
        string course;
        string collage;
        public void getdata(string name,string address,double mobileno,int rno,string course,string collage ) 
        {
            this.rno = rno;
            this.course = course;
            this.collage = collage;
            getdata(name,address,mobileno);
        }
        public void display()
        {
            base.display();
            Console.WriteLine(rno);
            Console.WriteLine(course);
            Console.WriteLine(collage);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student stud = new student();
            stud.getdata("Aditya", "Morshi", 8626065659, 105, "MBA", "G.H.Raisoni");
            stud.display();
            Console.ReadLine();
        }
    }
}
