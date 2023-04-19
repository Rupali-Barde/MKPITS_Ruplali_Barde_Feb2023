namespace StudentInfoProgram
{
    class Student
    {
        static void Main()
        {
            int rollno, age, mobileno;
            string name, course;
            Console.WriteLine("Enter roll no");
            Console.WriteLine("Enter age");
            Console.WriteLine("Enter mobileno");
            Console.WriteLine("Enter name");
            Console.WriteLine("Enter course");
            rollno=Convert.ToInt32(Console.ReadLine());
            age=Convert.ToInt32(Console.ReadLine());
            mobileno=Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
            course = Console.ReadLine();
            Console.WriteLine(rollno);
            Console.WriteLine(age);
            Console.WriteLine(mobileno);
            Console.WriteLine(name);
                Console.WriteLine(course);
            Console.ReadKey();


        }
    }
}
