using System;

namespace ReturnRandomNumberArray
{
    public class IntArray
    {
        public static int[] RandomIntUsingArray(int numElements, int maxVal)
        {
            Random myRandomNumber = new Random();
            int[] Array = new int[numElements];
            for (int i = 0; i < numElements; i++)
            {
                Array[i] = myRandomNumber.Next(maxVal);
            }
            return Array;
        }
        public static int GetMinValue(int[] myList)
        {
            //Get lowest value in list.
            int minListValue = int.MaxValue;
            for (int i = 0; i < myList.Length; i++)
            {
                if (myList[i] < minListValue)
                {
                    minListValue = myList[i];
                }
            }
            return minListValue;
        }
        public static int GetMaxValue(int[] myList)
        {
            //Get highest value in list.
            int maxListValue = 0;
            for (int i = 0; i < myList.Length; i++)
            {
                if (myList[i] < maxListValue)
                {
                    maxListValue = myList[i];
                }
            }
            return maxListValue;
        }
        public static int[] ArraySort(int[] unsortedList)
        {
            int[] sortedList = new int[unsortedList.Length];
            for (int i = 0; i < unsortedList.Length; i++)
            {
                sortedList[i] = GetMinValue(unsortedList);
            }
            return sortedList;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ReturnRandomNumberArray.IntArray.Main()");

            int numOfClasses = 6;
            int maxScore = 100;

            int[] myGrades = IntArray.RandomIntUsingArray(numOfClasses, maxScore);
            for (int i = 0; i < numOfClasses; i++)
            {
                Console.WriteLine($"{i} : {myGrades[i]}");
            }
        }
    }
}