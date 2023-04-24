using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {

            calculate();
        }
            static void calculate()
            {
                int num1, num2;
                Console.WriteLine("Entre num1");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter num2");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Calling addition function");
                 addition(num1, num2);
                

               
                Console.WriteLine("Calling subtraction function");
                subtraction(num1, num2);
                
                Console.ReadLine();
            }
            static void addition(int num1, int num2)
            {
                int result = num1 + num2;
                Console.WriteLine("Addition ="+ result);
            }
            static void subtraction(int num1, int num2)
            {
                int result = num1 - num2;
                Console.WriteLine("Subtraction ="+ result);
            }

        }
    }



    

