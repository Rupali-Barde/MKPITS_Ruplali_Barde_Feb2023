using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            char nonRepeat = '\0';
            for (int i = 0; i < input.Length; i++)
            {
                bool isRepeat = false;
                for (int j = 0; j < input.Length; j++)
                {
                    if (i != j && input[i] == input[j])
                    {
                        isRepeat = true;
                        break;
                    }
                }
                if (!isRepeat)
                {
                    nonRepeat = input[i];
                    break;
                }
            }

            if (nonRepeat != '\0')
            {
                Console.WriteLine("First non-repeating character is: " + nonRepeat);
            }
            else
            {
                Console.WriteLine("All characters are repeated in the input string.");
            }
            Console.ReadLine();
        }
    }
}
