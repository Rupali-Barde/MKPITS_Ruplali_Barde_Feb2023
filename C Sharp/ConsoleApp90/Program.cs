using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp90
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            int res = myfunct(5, 3);

        }
        static int myfunct(int x, int y)
        {
            if (y<=0)
            {
                return 1;
            }
            else
            {
                return x * myfunct(x, (y - 1));
                
            }
        }
    }
}
