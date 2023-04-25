using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp105
{
    class Account
    {
        public int actno;
        public string name;
        public static count;
            public Account(int actno, string name);
            {
             this.actno = actno;
             this.name = name;
             count++;
            }

    public void display()
    {
        Console.WriteLine("Account No :" + actno);
        Console.WriteLine("Name :" + name);

    }
}
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

