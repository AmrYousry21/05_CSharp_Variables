using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp1
{
    public interface ITrackable
    {
        public int MyProp { get; set; }
    }

    public interface IPoint
    {
        public int MyProperty { get; set; }
    }
    public struct Point
    {
        public int MyProperty { get; set; }

    }

    public class Dog
    {
        public int MyProperty { get; set; }

    }

    public static class Cat
    {
        public static int MyProperty { get; set; }

        public static void Meow()
        {
            Console.WriteLine("Meow");
        }
    }


    public class Methods : IPoint, ITrackable
    {
        public int MyProperty { get; set; }
        public int MyProp { get; set; }

        public void InstanceMethod()
        {
            Console.WriteLine("Instance Method");
        }

        public static void StaticMethod()
        {
            Console.WriteLine("Static Method");
        }
    }
}
