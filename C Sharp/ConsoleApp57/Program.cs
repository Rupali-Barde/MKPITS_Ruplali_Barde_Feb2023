using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = { { 4, 5,4 }, { 6, 8 ,2}, };
            int[,] arr2 = { { 14, 15,12 }, { 16, 17,11 } };
            int[,] arr3 = new int[3, 3];

            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    arr3[i,j]= arr1[i,j] + arr2[i,j];

                }
            }
            for(int i=0;i<3; i++)
            {
                for(int j=0;j<3; j++)
                {
                    Console.Write(arr3[i,j] +"\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
