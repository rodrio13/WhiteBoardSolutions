using System;

namespace sumOfOdds
{
    public class Program
    {
        public static int OddNumber()
        {
            do
            {
                int i;
                for (i = 0; i <= 11; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
                return i;
            } while (OddNumber() % 2 == 1);
        }
        static void Main(string[] args)
        {
            OddNumber();
        }
    }
}