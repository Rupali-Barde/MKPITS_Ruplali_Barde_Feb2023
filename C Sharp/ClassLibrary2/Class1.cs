using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class1
    {
        int bal = 1000;
         public string deposit(int amount)
        {
            bal = bal + amount;
            return "Balance is" + bal;
        }

        public string widthdraw(int amount)
        {
            bal = bal - amount;
            return "Balance is" + bal;
        }
    }
}
