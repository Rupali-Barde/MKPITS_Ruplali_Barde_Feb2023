using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr= new int[2, 3];
            for(int row = 0; row < 2; row++)
            {
                for(int col = 0; col < 2; col++)
                {
                    Console.WriteLine("Enter Number");
                    arr[row,col] = Convert.ToInt32(Console.ReadLine());
                    
                }
            }
            for(int row = 0;row < 2; row++)
            {
                for(int col = 0; col < 2; col++)
                {
                    Console.WriteLine(arr[row, col] + "\t");
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
