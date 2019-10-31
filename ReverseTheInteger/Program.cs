using System;

namespace ReversingIntegers
{
    public class ReverseTheInteger
    {
        //public static int MirrorTheInteger(int Number)
        //{
        //    string NumberAsString = Number.ToString();
        //    string ReverseNumberAsString = "";
        //    for (int i = 1; i <= NumberAsString.Length; i++)
        //    {
        //        ReverseNumberAsString += NumberAsString[NumberAsString.Length - i];
        //    }
        //    int MirrorNumber = Convert.ToInt32(ReverseNumberAsString);
        //    return MirrorNumber;
        //}
        public static int Reverse(int X)
        {
            bool isNeg = (X < 0);
            int sum = 0;

            X *= isNeg ? -1 : 1;
            while (X > 0)
            {
                sum *= 10;
                int remainder = X % 10;
                sum += remainder;
                X /= 10;
            }

            sum *= isNeg ? -1 : 1;
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ReversingIntegers.ReverseTheIntegers.Main()");
            //Console.WriteLine(MirrorTheInteger(98765));
            Console.WriteLine(Reverse(98765));
        }
    }
}