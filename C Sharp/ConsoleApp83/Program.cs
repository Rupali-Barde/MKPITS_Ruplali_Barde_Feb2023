using ConsoleApp83;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp83
{
    class person
    {
        string name;
        string address;
        public void getdata(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void display()
        {
            Console.WriteLine(name);
            Console.WriteLine(address);
        }

    }
    class customer : person
    {
        int custid;
        public void getdata(int custid, string name, string address)
        {
            this.custid = custid;
            getdata(name, address);
        }
            public void display()
            {
                base.display();
                Console.WriteLine(custid);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        { 
        customer cust = new customer();
        cust.getdata(123, "Aditya", "Nagpur");
        cust.display();Console.ReadLine();
        }
    }

