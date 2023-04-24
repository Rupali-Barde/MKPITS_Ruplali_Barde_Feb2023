using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp99
{
    interface IAccount
    {
        string deposit(int amt);
    }
    abstract class Account : IAccount
    {
        public int balance = 1000;
        public abstract string deposit(int amt);
        public string showbalance()
        {
            return("bal is :" + balance.ToString());
        }
    }
    class saving : Account
    {
        int intrest = 500;
        public override string deposit(int amt) 
        {
            balance = balance + amt + intrest;
            return ("Amount deposited with intrest bal is" + balance);

        }
    }
    class current : Account
    {
        public override string deposit(int amt) 
        {
            balance = balance + amt;
            return ("amount deposited without intrest bal is" + balance);
        }
    }
    internal class Program
    {
        static void Main(string[] args)

        { 
            Account act = null;
            string acttype;
            Console.WriteLine("Enter Account Type" );
            acttype = Console.ReadLine();
            Console.WriteLine("Enter Amount To Be :");
            int amount = Convert.ToInt32(Console.ReadLine());
            if(acttype == "Saving")
            {
                act = new saving(); 
            }
            else if (acttype =="current")
            {
                act = new current();
            }
            string res = act.deposit(amount);
            Console.WriteLine(res);
            Console.WriteLine(act.showbalance());
            Console.ReadLine();

        }
        
    }
}

