using System;

namespace OddTest
{
    public class Program
    {
        public static bool OddTest(int Number)
        {
            return (Number % 2 == 1);
        }
        public static void testOddTest()
        {
            Console.WriteLine($"\t5: is Odd? {OddTest(5)}");
            Console.WriteLine($"\t8: is Odd? {OddTest(8)}");
            Console.WriteLine($"\t0: is Odd? {OddTest(0)}");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\tOddTest.Main()\n");
            testOddTest();
        }
    }
}