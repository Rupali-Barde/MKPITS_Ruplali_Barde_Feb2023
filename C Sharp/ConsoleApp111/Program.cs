using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp111
{
    class person
    {
        public virtual void display()
        {
            Console.WriteLine("Hello From person");
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

        /*public override void display()
        {
            Console.WriteLine("Hello From PartTime Student");
        }*/
        public void pshow()
        {
            Console.WriteLine("Hello Guys");

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            person  p = new person();
            p.display();
           partstudent ps1 = new partstudent();
            ps1.display();
            Console.ReadLine();
        }
    }
}
