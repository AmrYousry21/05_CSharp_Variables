using System;

namespace EnumsDemo
{
    public class EnumTest
    {
        public enum Days { Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday };
        public enum BoilingPoints { Celsius = 100, Fahrenheit = 212 };
        [Flags]
        public enum Colors { Red = 1, Green = 2, Blue = 4, Yellow = 8 };

    }
    class Program
    {
        static void Main(string[] args)
        {
            Type weekdays = typeof(EnumTest.Days);
            Type boiling = typeof(EnumTest.BoilingPoints);

            Console.WriteLine("The days of the week, and their corresponding values in the Days Enum are:");
            Console.WriteLine("**************************************************************************");

            foreach (string s in Enum.GetNames(weekdays))
                Console.WriteLine("{0,-11}= {1}", s, Enum.Format(weekdays, Enum.Parse(weekdays, s), "d"));

            Console.WriteLine();
            Console.WriteLine("Enums can also be created which have values that represent some meaningful amount!");
            Console.WriteLine();
            Console.WriteLine("The BoilingPoints Enum defines the following items, and corresponding values:");
            Console.WriteLine("*****************************************************************************");

            foreach (string s in Enum.GetNames(boiling))
                Console.WriteLine("{0,-11}= {1}", s, Enum.Format(boiling, Enum.Parse(boiling, s), "d"));

            EnumTest.Colors myColors = EnumTest.Colors.Red | EnumTest.Colors.Blue | EnumTest.Colors.Yellow;
            Console.WriteLine();
            Console.WriteLine("myColors holds a combination of colors. Namely: {0}", myColors);
        }
    }
}
