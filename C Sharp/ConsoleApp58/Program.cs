using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n, i, j;
            Console.WriteLine("Enter The Order of Matrix:");
            m = Convert.ToInt16(Console.ReadLine());
            n = Convert.ToInt16(Console.ReadLine());
            int[,] A = new int[10, 10];
            {
                for(i=0;i<m;i++)
                {
                    for(j=0;j<n;j++)
                        A[i,j]= Convert.ToInt16(Console.ReadLine());

                }
            }
            Console.Clear();
            Console.WriteLine("\n Matrix A:");
            for(i=0;i<=m;i++)
            {
                for(j=0 ; j <= n; j++)
                {
                    Console.Write(A[i,j] +"\t");
                }
                Console.WriteLine();
                    
            }
            Console.WriteLine("Transpose Matrix");
            for(i=0;i<=m;i++)
            {
                for(j=0 ; j<=n; j++)
                {
                    Console.Write(A[i, j] + "\t");

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
