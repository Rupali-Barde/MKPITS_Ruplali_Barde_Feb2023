using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            int counter;
            int isprime = 0;
            for(counter=2;counter<num;counter++)
                {
                if(num%counter == 0)
                {
                    isprime = 1; 
                    break;

                }
                 if(isprime==0)
                
                {
                    Console.WriteLine("It is a prime number");
                }
                else
                {
                    Console.WriteLine("It is not a prime Number");
                    
                }
                Console.ReadKey();

            }
        }
    }
}
