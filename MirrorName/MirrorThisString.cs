using System;

namespace MirrorName
{
    public class MirrorThisString
    {
        public static string StringMirror(string Forwards)
        {
            string Backwards = "";

            for (int i = 1; i <= Forwards.Length; i++)
            {
                Backwards += Forwards[Forwards.Length - i];
            }
            return Backwards;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("MirrorName.MirrorThisString.Main()");
            Console.WriteLine(StringMirror("Omar"));
        }
    }
}