using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[3];
            arr[0] = "Amit";
            arr[1] = "Raj";
            arr[2] = "Ravi";
            foreach (string val in arr)

            {
                Console.WriteLine("String =" +val);
            }
            Console.ReadLine(); 

            
        }
    }
}
