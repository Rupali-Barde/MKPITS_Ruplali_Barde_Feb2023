using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp102
{
    class Account
    {
        public int actno;
        public string name;
        public static float roi = 4.5f;
        public Account(int actno, string name)
        {
            this.actno = actno;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine("Account No :" + actno);
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Rate of Intrest :" + roi);

        }
           
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(123, "Rupali");
            Account a2 = new Account(465, "Shreya");
            Account.roi = 33.4f;
            a1.display();
            a2.display();
            Console.ReadLine();
        }
        
    }
}
