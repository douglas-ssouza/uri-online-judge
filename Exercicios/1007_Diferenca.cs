using System;

namespace Diferenca
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, difer;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

            difer = ((a * b) - (c * d));

            Console.WriteLine("DIFERENCA = " + difer);
        }
    }
}