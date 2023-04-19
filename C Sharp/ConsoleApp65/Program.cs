using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp65
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Shantshahu";
            char result = '\0';
            int ind = 0;
            for(int i=0; i<args.Length; i++)
            {
                bool isRepeated = false;
                for(int j=0; j < args[i].Length; j++)
                {
                    if(i!=j && input[i] == input[j])
                    {
                        isRepeated = true;
                        break;
                    }
                }
                if(!isRepeated)
                {
                    result = input[i];
                    ind = i;
                    break;
                }
            }
            if(result != '\0')
            {
                Console.WriteLine("The First Non-Repeated Character In The String is :{0}", result);
                Console.WriteLine("The First Non-Repeated Character Index In The String is :{0}", ind);
            }
            else
            {
                Console.WriteLine("There Are No Non-Repeated Character In The String ");
            }
            Console.ReadLine();
        }
    }
}
