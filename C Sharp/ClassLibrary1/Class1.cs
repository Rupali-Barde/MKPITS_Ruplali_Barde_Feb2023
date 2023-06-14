using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        //Creating Method
        public string Addition(int n1, int n2)
        {
          int res = n1 + n2;
         return "addition is" + res.ToString();
        }

        public string Subtraction(int n1,int n2)
        {
            int res = n1 - n2;
            return "Subtraction is" + res.ToString();
        }

        public string Multiplication(int n1,int n2) 
        {
            int res = n1 * n2;
            return "Multiplication is" + res.ToString();
        }

        public string Division(int n1,int n2)
        {
            int res = n1 / n2;
            return "Division is"+ res.ToString();
        }

    }
}
