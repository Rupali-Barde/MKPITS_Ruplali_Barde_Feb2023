using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp79
{
    class person
    {
        public string name;
    }
    class student : person 
    {
        public int rno;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.rno = 111;
            s.name = "rajesh";
            Console.WriteLine("rno" +s. rno);
            Console.WriteLine("name" + s.name);
            Console.ReadLine();
        }
    }
}
