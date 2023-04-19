using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean isfound = false;
            int[] arr ={ 1, 2, 3, 4, 5 };
            int num;
            Console.WriteLine("Enter number to be found");
            num = Convert.ToInt32(Console.ReadKey());
            for(int counter = 0; counter < arr.Length; counter++)
            {
                if (arr[counter] == 0) 
                {
                   isfound = true;
                    break;
                }
            }
             if(isfound == true)
            {
                Console.WriteLine(num + "found in array");

            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
