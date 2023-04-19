using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp76
{
    class car
    {
        string model_name;
        string color;
        string brand;
        public void getdata(string mn, string c, string b)
        {
            model_name = mn;
            color = c;
            brand = b;
        }
        public void displaydata()
        {
            Console.WriteLine("model_name" + model_name);
            Console.WriteLine("color" + color);
            Console.WriteLine("brand" + brand);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            car car1 = new car();
            Console.WriteLine("Enter Model_Name");
            string model_name = Console.ReadLine();
            Console.WriteLine("Enter Color");
            string color = Console.ReadLine();
            Console.WriteLine("Enter Brand");
            string brand = Console.ReadLine();
            car1.getdata(model_name, color, brand);
            car1.displaydata();
            Console.ReadLine();
        }
    }
}
