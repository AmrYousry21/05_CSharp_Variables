using System;
using System.Collections.Generic;

namespace DataTypeDemo
{
    class Program
    {
        public struct GeoCoordinate
        {
            public int X;
            public int Y;
        }

        static void Main(string[] args)
        {
            GeoCoordinate geo1;
            GeoCoordinate geo2;

            // declaring and initializing
            char middleInitial = 'C';
            string firstName = "John";

            // declaring a variable of type string called myName
            string myName;

            // initialize this variable with a value
            myName = "John Doe";

            // declare and initialize a variable
            string myOtherName = "John Smith";

            Console.Write("Hey, please input your name here: ");
            string fullName = Console.ReadLine(); // taking in a user's input and storing it in the fullName variable
            Console.WriteLine("Hello " + fullName);

            // re-initializing a variable 
            fullName = "";

            // declaring and initializing a variable of type double
            char variable1;
            double variable2;
            string variable3;           

                          
            //-----------------------------------------------------------------------------------------------------------------------------------

            byte byteMin = 0; //8-bit unsigned integer
            byte byteMax = 255; //8-bit unsigned integer
            
            sbyte sByteMin = -128; //8-bit unsigned integer
            sbyte sByteMax = 127; //8-bit unsigned integer

            short shortMin = -32768; //16-bit signed integer
            short shortMax = 32767; //16-bit signed integer

            ushort uShortMin = 0; //16-bit unsigned integer
            ushort uShortMax = 65535; //16-bit unsigned integer

            int intMin = -2147438648; //32-bit unsigned integer
            int intMax = 2147483647; //32-bit unsigned integer

            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types#real-literals
            //--------------------------------------------------------------------------------------------------------------------------------------------
            //The value of unsigned integers, long, float, and decimal type must be suffixed by u,l,f, and m.
            //                                                                                          U,L,F, and M
            uint uIntMin = 0; //32-bit unsigned integer
            uint uIntMax = 4294967295; //32-bit unsigned integer
            uint uIntExample = 100u;

            long longMin = -9223372036854775808; //64-bit unsigned integer
            long longMax = 9223372036854775807; //64-bit unsigned integer
            long longExample = 45755452222222L; // use uppercase L because lowercase l & 1 look almost identical

            ulong uLongMin = 0; //64-bit unsigned integer
            ulong uLongMax = 18446744073709551615; //64-bit unsigned integer
            ulong uLongExample = 45755452222222UL;


            float floatMin = Single.MinValue; // -3.402823e38 32-bit Single-precision floating point type
            float floatMax = Single.MaxValue; // 3.402823e38 32-bit Single-precision floating point 
            float floatExample = 0.0f;

            double doubleMin = Double.MinValue; // -1.7976931348623157E+308 64-bit Double-precision floating point type
            double doubleMax = Double.MaxValue; // 1.7976931348623157E+308 64-bit Double-precision floating point 
            double doubleExample = 0.00000; //You do not need the d\D for Double


            decimal decimalMin = Decimal.MinValue; //-79228162514264337593543950335 128-bit 
            decimal decimalMax = Decimal.MaxValue; //79228162514264337593543950335
            decimal decimalExample = 0.0000001M;
            //---------------------------------------------------------------------------------------------------------------------------------------------


            char charExample = 'a'; //Any valid character, (e.g.) a, *, \x0058 (hex), or \u0058 (Unicode)

            string stringExample = "Hello World!"; //A sequence of Unicode characters

            bool boolExampleTrue = true;
            bool boolExampleFalse = false;

            object objectExample1 = true; //Base type of all other types. (It can be pretty much anything)
            object objectExample2 = 1;
            object objectExample3 = 0.0000F;
            object objectExample = new int[] { 1, 2, 3 };


            DateTime dateTimeExample = DateTime.Now; //0:00:00am 1/1/01 to 11:59:59pm 12/31/9999

            //-----------------------------------------------------------------------------------------------------------------------------------------------------
            //Console.WriteLine(decimalMin);
            /*
             Conversions             
                The values of certain data types are automatically converted to different data types in C#. This is called an implicit conversion.

                Example: Implicit Conversion               
                int i = 345;
                float f = i;

                Console.WriteLine(f); //output: 345

            In the above example, the value of an integer variable i is assigned to the variable of float type f because this conversion operation is predefined in C#.

            -------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            The following is an implicit data type conversion table.

              Implicit Conversion From  ---->   To
            __________________________________________________________________________________________________________________________________________________________
                |sbyte                 |     | short,      |int,        |long,       |float,      |double,     |decimal
                |byte                  |     | short,      |ushort,     |int,        |uint,       |long,       |ulong,      |float,       |double,      |decimal
                |short                 |     | int,        |long,       |float,      |double,     |decimal     |            |             |             |
                |ushort                |     | int,        |uint,       |long,       |ulong,      |float,      |double,     |decimal      |             |
                |int                   |     | long,       |float,      |double,     |decimal     |            |            |             |             |
                |uint                  |     | long,       |ulong,      |float,      |double,     |decimal     |            |             |             |
                |long                  |     | float,      |double,     |decimal     |            |            |            |             |             |
                |ulong                 |     | float,      |double,     |decimal     |            |            |            |             |             |
                |char                  |     | ushort,     |int,        |uint,       |long,       |ulong,      |float,      |double,      |decimal      |
                |float                 |     | Double      |            |            |            |            |            |             |             |   
            ___________________________________________________________________________________________________________________________________________________________           */

        }
    }
}
