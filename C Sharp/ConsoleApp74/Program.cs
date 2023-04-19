using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp74
{
    class product
    {
        int pno;
        int pid;
        string pname;
        public void getdata(int no,int id,string n)
        {
            pno = no;
            pid = id;
            pname = n;
        }
        public void displaydata()
        {
            Console.WriteLine("pno" + pno);
            Console.WriteLine("pid" + pid);
            Console.WriteLine("pname" + pname);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            product pro1 = new product();
            Console.WriteLine("Enter pno");
            int pno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter pid");
            int pid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter pname");
            string pname = Console.ReadLine();
            pro1.displaydata();
            Console.WriteLine();
        }
    }
}
