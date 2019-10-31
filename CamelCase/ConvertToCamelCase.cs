using System;

namespace CamelCase
{
    public class ConvertToCamelCase
    {
        public static string toCamelCase(string inputString)
        {
            string camelCaseString = "";

            inputString = inputString.ToLower();

            for (int i = 0; i < inputString.Length; i++)
            {
                char nextChar = inputString[i];
                if (nextChar == ' ')
                {
                    nextChar = char.ToUpper(inputString[++i]);
                }
                camelCaseString += nextChar;
            }
            return camelCaseString;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("CamelCase.ConvertToCamelCase.Main()");
            string str = "When in the course of human events.";
            Console.WriteLine($"{str} --> {toCamelCase(str)}");
        }
    }
}