﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int counter;
            
            for(int outercounter=1;outercounter<=20;outercounter++)
            {
                int num = outercounter;
                int isprime = 0;
                for (counter = 2; counter < num; counter++)
                {
                    if (num % counter == 0)
                    {
                        isprime = 1;
                        break;
                    }
                }
                    if(isprime == 0)
                    {
                        Console.WriteLine(num +" is a prime number" );

                    }

                    Console.ReadLine();
                    }


            }
        }
    }

