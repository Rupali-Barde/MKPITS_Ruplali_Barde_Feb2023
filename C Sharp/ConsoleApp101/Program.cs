using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp101
{
    class person
    {
        public virtual void display()
        {
            Console.WriteLine("Hello From Person");
        }
    }
    class student : person
    {
        public sealed override void display()
        {
            Console.WriteLine("Hello From Student");
        }

    }
    class partstudent : student
    {
        
        public void pshow()
        {
            Console.WriteLine("Hello Guys");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            person p = new person();
            p.display();
            p.pshow();

        }
    }
}
