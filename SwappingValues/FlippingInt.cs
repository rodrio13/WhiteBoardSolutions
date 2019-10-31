using System;

namespace SwapingValues
{
    public class FlippingInt
    {
        public static string FlipTheValues(double A, double B)
        {
            if (A == B)
            {
                Console.WriteLine($"Value A ({A}) and Value B ({B})");
            }
            Console.WriteLine($"A = {A}, B = {B}");
            A = A + B;
            B = A - B;
            A = A - B;
            Console.WriteLine($"A = {A}, B = {B}");
            return $"{A} and {B}";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("SwappingValues.FlippingInt.Main()");
            FlipTheValues(9, 3);
        }
    }
}