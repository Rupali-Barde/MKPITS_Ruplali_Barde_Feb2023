using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            float area, cir;
            Console.WriteLine("Enter Number");
           radius=Convert.ToInt32(Console.ReadLine());
            calculatearea(radius, out area, out cir);
            Console.WriteLine("Area =" + area);
            Console.WriteLine("Circumference =" + cir);
            Console.ReadLine();
        }
        static void calculatearea(int r,out float a,out float c)
        {
            a = 3.14f * r * r;
            c = 2 * 3.14f * r;
        }
    }
}
