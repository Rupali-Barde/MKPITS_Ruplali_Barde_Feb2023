using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Character
    {
        static void Main(string[] args)
        {
            char ch ;
            Console.WriteLine("Enter char");
            ch=Convert.ToChar(Console.ReadLine());
            if (ch=='a' || ch=='e'||  ch=='i' || ch=='o' || ch=='u')
            {
                Console.WriteLine("char is vowel");

            }
            else if(ch>='a' && ch<='z')
            {
                Console.WriteLine("char is consonat");

            }
            else
            {
                Console.WriteLine("It is not Character");
            }
            Console.ReadLine();

        }
    }
}
