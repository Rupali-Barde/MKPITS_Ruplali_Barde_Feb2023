using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp116
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            try
            {
                Console.WriteLine("Enter Age");
                age = Convert.ToInt32(Console.ReadLine());
                if(age <=0 || age >100)
                {
                    throw new Exception("Enter Proper Age");
                }
                else
                {
                    Console.WriteLine("Your Age is :" + age);
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
              Console.WriteLine("Welcome");
            }
            Console.WriteLine("Bye");
            Console.ReadLine();
        }
    }
}
