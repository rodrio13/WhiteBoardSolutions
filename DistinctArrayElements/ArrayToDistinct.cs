using System;

namespace DistinctArrayElements
{
    public class ArrayToDistinct
    {
        public static int GiveDistinctCount(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                bool state = true;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        state = false;
                    }
                }
                if (state)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("DistinctArrayElements.ArrayToDistinct.Main()\n");
            Console.WriteLine(GiveDistinctCount(new int[] { 1, 2, 3, 4, 5, 1, 2 }));
        }
    }
}