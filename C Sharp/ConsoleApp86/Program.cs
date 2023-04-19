using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp86
{
    public class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating");

        }
    }
    class Dog : Animal
    {
        public void bark()
        {
            Console.WriteLine("Barking");
        }
    }
    class BabyDog : Dog
    {
        public void weep ()
        {
            Console.WriteLine("Weeping");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BabyDog dog = new BabyDog();
            dog.eat();
            dog.bark();
            dog.weep();
            Console.ReadLine();
        }
    }
}
