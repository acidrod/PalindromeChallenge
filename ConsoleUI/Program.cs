using System;
using Helper;

namespace ConsoleUI
{
    class Point
    {
        public int xCoord { get; set; }
        public int yCoord { get; set; }

        public Point(int x, int y)
        {
            xCoord = x;
            yCoord = y;
        }

        public double Distance(Point q)
        {
            double x1, x2, y1, y2;
            x1 = xCoord;
            x2 = q.xCoord;
            y1 = yCoord;
            y2 = q.yCoord;

            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }
    }

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
