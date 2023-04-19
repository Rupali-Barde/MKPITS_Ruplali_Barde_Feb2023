using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Consonant
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter char");
            ch=Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("char is vowel");
                    break;
                case 'e':
                    Console.WriteLine("char is vowel");
                    break;
                case 'i':
                    Console.WriteLine("char i svowel");
                    break;
                case 'o':
                    Console.WriteLine("char is vowel");
                    break;
                case 'u':
                    Console.WriteLine("char is vowel");
                    break;
                default:
                    Console.WriteLine("Char is consonant");
                    break;
            }
            Console.WriteLine("This is alphabet");
            Console.ReadLine();


            }
        }
    }

