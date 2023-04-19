using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp92
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, primeNo;
            Console.Write("Input any Positive Nuumber :");
            n1 = Convert.ToInt32(Console.ReadLine());
            primeNo = checkforPrime(n1, n1 / 2);

            if (primeNo == 1)
            {
                Console.Write("The number {0} is a prime number \n\n.", n1);


            }
            else
            {
                Console.Write("The nuumber {0} is not a prime number \n\n.", n1);
                return 0;
            }
            static int checkforPrime(int n1, int i)
            {
                if (i == 1)
                {
                    return 1;


                }
                else
                {
                    if (n1 % i == 0)
                        return 0;
                    else
                    {
                        return checkforPrime(n1, i - 1);
                    }
                }
            }
        }
    }
}

