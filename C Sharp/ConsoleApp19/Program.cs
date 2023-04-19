using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Bonus    
    {
        static void Main(string[] args)
        {
            string empname, designation;
            int bonus = 0;
            Console.WriteLine("Enter empname");
            empname=Console.ReadLine();
            Console.WriteLine("Enter designation");
            designation = Console.ReadLine();
            switch (designation)
            {
                case "Manager":
                    bonus = 10000;
                    break;
                case "Clerk":
                    bonus = 5000;
                    break;
                case "peon":
                    bonus = 2000;
                    break;
                default:
                    Console.WriteLine("Invalid Designation");
                    break;
            }
            Console.WriteLine("empname={0},bonus={1},empname,bonus");
            Console.ReadLine();


                    

            }
        }
    }

