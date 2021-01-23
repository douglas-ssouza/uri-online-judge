using System;

namespace Galopeira
{
    class Program
    {
        static void Main(string[] args)
        {
            int casos, digitos;
            string galopeira;
            double tempo;

            casos = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < casos; i++)
            {
                galopeira = Console.ReadLine();
                digitos = galopeira.Length;
                tempo = (double) digitos / 100;

                Console.WriteLine("{0}", tempo.ToString("0.00"));
            }
        }
    }
}
