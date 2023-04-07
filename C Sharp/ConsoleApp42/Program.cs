using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] arr =  new float[5];
            arr[0] = 120.4f;
            arr[1] = 130.05f;
            arr[2] = 140.7f;
            arr[3] = 150.8f;
            arr[4] = 160.9f;
            foreach (float f in arr) 
            {
                Console.WriteLine(f);
            }
            Console.ReadLine();
        }
    }
}
