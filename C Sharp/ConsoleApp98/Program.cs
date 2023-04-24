using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp98
{
    interface interface1
    {
        void method();
    }
    class baseclass 
    {
        public void basemethod()
        {
            Console.WriteLine("Hello from base method");
        }
    }
    class class1 : baseclass,interface1
    {
        public void method1()
        {
            Console.WriteLine("Hello from method1");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            interface1 a1 = new class1();
            a1.method1();
           
        }
        
    }
    
}
