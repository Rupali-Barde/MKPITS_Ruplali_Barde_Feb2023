using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Result
    {
        static void Main(string[] args)
        {
            int s1, s2, s3, total;
            float per;
            string grade = "";
            Console.WriteLine("Enter Sub1 Marks");
            s1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Sub2 Marks");
            s2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Sub3 Marks");
            s3=Convert.ToInt32(Console.ReadLine());
            total=s1+s2+s3;
            per=(total / 300.00f) * 100.0f;
            Console.WriteLine("Total is :" + total);
            Console.WriteLine("Per is :" + per);
                if (per >= 75)
            {
                grade = "Distinction";
            }
                else if (per >= 60 && per< 75)
                    {
                grade = "First";
            }
            else{
                grade = "fail";

            }
            Console.WriteLine("Grade =" + grade);
            Console.ReadLine();


        }
    }
}
