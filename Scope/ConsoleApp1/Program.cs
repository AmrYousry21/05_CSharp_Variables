using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) // Parameter
        {
            Console.WriteLine("Hello World!"); // Argument


            Methods m = new Methods();
            m.InstanceMethod();

            Methods.StaticMethod();

            Cat.Meow();

        }
    }
}
