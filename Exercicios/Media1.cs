using System;

namespace Media1
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;

            nota1 = Convert.ToDouble(Console.ReadLine());
            nota2 = Convert.ToDouble(Console.ReadLine());
            media = ((nota1 * 3.5) + (nota2 * 7.5)) / 11;

            Console.WriteLine("MEDIA = " + Math.Round(media, 5));
        }
    }
}