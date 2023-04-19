using System;
namespace Square
{
    class square
    {
        static void Main()
        {
            int num, square;
            Console.WriteLine("please enter number");
            num = Convert.ToInt32(Console.ReadLine());
            square = num * num;
            Console.WriteLine("Square of a number is" + square);
            Console.ReadKey();

        }
    }
}
