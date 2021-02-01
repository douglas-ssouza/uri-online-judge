using System;

namespace CachorrosQuentes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] linha = Console.ReadLine().Split(' ');

            int hotdogs = Convert.ToInt32(linha[0]);
            int pessoas = Convert.ToInt32(linha[1]);

            double media = (double) hotdogs / pessoas;

            Console.WriteLine("{0}", media.ToString("0.00"));
        }
    }
}
