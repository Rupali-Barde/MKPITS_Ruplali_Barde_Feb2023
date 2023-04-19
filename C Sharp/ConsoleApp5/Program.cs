namespace AddProgram
{
    class Addition3
    {
        static void Main()
        {
            int num1, num2, num3, add;
            Console.WriteLine("Enter num1");
            Console.WriteLine("Enter num2");
            Console.WriteLine("Enter num3");
            num1=Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            add=num1 + num2+num3;
            Console.WriteLine("Addition of 3 num is" + add);
            Console.ReadLine();







        }
    }
}
