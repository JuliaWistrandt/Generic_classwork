using System.Collections.Generic;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = 10; // int? first = 10 is a fail signature because struct takes no null value
            int second = 20;
            Swap(ref first, ref second);
            Console.WriteLine($"first number is {first}, second number is {second}");

            //string frt = "first value";
            //string scnd = "second value";
            //Swap(ref frt, ref scnd);
            //Console.WriteLine($"first number is {frt}, second number is {scnd}");


        }

        public static void Swap<T>(ref T first, ref T second)  where T : struct
        {
            T ret = first;
            first = second;
            second = ret;

        }
    }
    
}