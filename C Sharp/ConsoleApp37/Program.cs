using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            float area, cir;
            Console.WriteLine("Enter number");
            radius = Convert.ToInt32(Console.ReadLine());
            area = 0.0f;
            cir = 0.0f;
            calculatearea(radius, ref area, ref cir);
            Console.WriteLine("Area =" + area);
            Console.WriteLine("Circumference =" + cir);
            Console.ReadKey();


        }

        static void calculatearea(int r, ref float a, ref float c)
        {
            a = 3.14f * r * r;
            c = 2 * 3.14f * r;
        }
    }
}
    

