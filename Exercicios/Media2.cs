using System;

namespace Media2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, media;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());

            media = ((a * 2) + (b * 3) + (c * 5)) / 10;

            Console.WriteLine("MEDIA = " + Math.Round(media, 1));
        }
    }
}
