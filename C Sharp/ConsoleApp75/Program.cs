using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp75
{
    class customer
    {
        int cusid;
        string cusname;
        string address;
        public void getdata(int id,string n,string a)
        {
            cusid= id;
            cusname = n;
            address = a;
        }
        public void displaydata()
        {
            Console.WriteLine("cusis" + cusid);
            Console.WriteLine("cusname" + cusname);
            Console.WriteLine("address" + address);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            customer cus = new customer();
            Console.WriteLine("Enter cusid");
            int cusid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter cusname");
            string cusname = Console.ReadLine();
            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            cus.displaydata();
            Console.ReadLine();


        }
    }
}
