using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp100
{
    sealed class employee
    {
        public void showdata()
        {
            Console.WriteLine("Hello");

        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.showdata();
        }
        
    }
}
