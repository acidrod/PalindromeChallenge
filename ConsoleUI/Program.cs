using System;
using Helper;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Allí cesó tu sed, ¿Oyes eso, Jair amada? ¿Has oído a la odiosa hada María José? Sé yo de su tosecilla";
            Console.WriteLine(phrase.IsPalindrome());

            int iPalin = 12321;
            Console.WriteLine(iPalin.IsPalindrome());

            double dPalin = 12.321;
            Console.WriteLine(dPalin.IsPalindrome());

            Console.WriteLine("Maps, DNA, and spam".IsPalindrome());
        }
    }
}
