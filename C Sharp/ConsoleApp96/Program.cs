using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp96
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount;
            Console.WriteLine("Enter amount");
            amount = Convert.ToInt32(Console.ReadLine());
            Account act = null;
            string Acttype;
            Console.WriteLine("Enter AccountType Saving Or Current");
            Acttype = Console.ReadLine();
            if (Acttype == "Saving")
            {
                act = new Saving();
            }
            else if (Acttype == "Current")
            {
                act = new Current();
            }
            act.deposit (amount);
            String res = act.showbalance();
            Console.WriteLine(res);
            Console.ReadLine();

            }
        }
    }
abstract class Account
{
    public int bal = 1000;
public abstract void deposit(int amt);
public string showbalance()
{
        return ("bal is" + bal);

}
}
class Saving : Account
{
    int intrest = 500;
    public override void deposit (int amt)
    {
        bal = bal + amt + intrest;
        Console.WriteLine("Deposite bal is " + bal);

    }

}
class Current : Account
{
    public override void deposit(int amt)
    {
        bal = bal + amt;
        Console.WriteLine("Deposited with intrest but is " + bal);
    }

}

