using System;
using Microsoft.VisualBasic;

namespace PrimeNumberCheck
{
    public class CheckNumberIsPrime
    {
        public static bool IsPrime(int Number)
        {
            if (Number <= 1) return false;
            for (int i = 2; i < Number; i++)
            {
                if (Number % 2 == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("PrimeNumberCheck.CheckNumberIsPrime.Main()\n");
            Console.WriteLine(IsPrime(113));
        }
    }
}