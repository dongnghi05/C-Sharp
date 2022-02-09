using System;

namespace UnderstandingTypes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1/");
            Console.WriteLine("Minimum value sbyte: " + sbyte.MinValue);
            Console.WriteLine("Maximum value sbyte: " + sbyte.MaxValue);
            Console.WriteLine();

            Console.WriteLine("Minimum value byte: " + byte.MinValue);
            Console.WriteLine("Maximum value byte: " + byte.MaxValue);
            Console.WriteLine();

            Console.WriteLine("Minimum value short: " + short.MinValue);
            Console.WriteLine("Maximum value short: " + short.MaxValue);
            Console.WriteLine();

            Console.WriteLine("Minimum value ushort: " + ushort.MinValue);
            Console.WriteLine("Maximum value ushort: " + ushort.MaxValue);
            Console.WriteLine();

            Console.WriteLine("Minimum value int: " + int.MinValue);
            Console.WriteLine("Maximum value int: " + int.MaxValue);
            Console.WriteLine();

            Console.WriteLine("Minimum value uint: " + uint.MinValue);
            Console.WriteLine("Maximum value uint: " + uint.MaxValue);
            Console.WriteLine();

            Console.WriteLine("Minimum value long: " + long.MinValue);
            Console.WriteLine("Maximum value long: " + long.MaxValue);
            Console.WriteLine();

            Console.WriteLine("Minimum value ulong: " + ulong.MinValue);
            Console.WriteLine("Maximum value ulong: " + ulong.MaxValue);
            Console.WriteLine();

            Console.WriteLine("Minimum value float: " + float.MinValue);
            Console.WriteLine("Maximum value float: " + float.MaxValue);
            Console.WriteLine();

            Console.WriteLine("Minimum value double: " + double.MinValue);
            Console.WriteLine("Maximum value double: " + double.MaxValue);
            Console.WriteLine();

            Console.WriteLine("Minimum value decimal: " + decimal.MinValue);
            Console.WriteLine("Maximum value decimal: " + decimal.MaxValue);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("2/");
            Console.Write("Input: ");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Output: " +
                input + " centuries = " +
                input * 100 + " years = " +
                input * 36524 + " days = " +
                input * 876576 + " hours = " +
                input * 52594560 + " minutes = " +
                input * 3155673600 + " seconds = " +
                input * 3155673600000 + " milliseconds = " +
                input * 3155673600000000 + " microseconds = " +
                input * 3155673600000000000 + " nanoseconds");


        }
    }
}
