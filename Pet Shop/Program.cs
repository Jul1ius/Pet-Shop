using System;

namespace Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dogpack = double.Parse(Console.ReadLine());
            double dogpackPrice = dogpack * 2.50;

            double catpack = double.Parse(Console.ReadLine());
            double catpackPrice = catpack * 4;

            double tottal = dogpackPrice + catpackPrice;

            Console.WriteLine($"{tottal} lv.");
        }
    }
}
