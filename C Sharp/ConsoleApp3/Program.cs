namespace AddProgram
{
    class Addition
    {
        static void Main()
        {
            int num1, num2, add;
            Console.WriteLine("Please enter num1");
            Console.WriteLine("Please enter num2");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            add = num1 + num2;
            Console.WriteLine("Addition of a number is" + add);
            Console.ReadKey();

        }

    }
}
