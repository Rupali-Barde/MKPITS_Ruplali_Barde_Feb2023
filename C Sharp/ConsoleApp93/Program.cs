using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp93
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res = myfunc(5, 3);
            Console.WriteLine(res);

        }
        static int myfunc(int x, int y)
        {
            if (y <= 0)
            {
                return 1;
            }
            else
            {
                return x + myfunc(x, y - 1);
            }
            Console.ReadKey();
            

        }
    }
}
