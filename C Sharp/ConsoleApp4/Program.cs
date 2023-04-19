namespace AreaProgram
{
    class Area
    {
       static void Main()
        {
            int length, breadth, area;
            Console.WriteLine("Enter length");
            Console.WriteLine("Enter breadth");
            length = Convert.ToInt32(Console.ReadLine());
            breadth = Convert.ToInt32(Console.ReadLine());
            area = length * breadth;
            Console.WriteLine("Area of a rectangle" + area);
            Console.ReadKey();



        }
    }
}
