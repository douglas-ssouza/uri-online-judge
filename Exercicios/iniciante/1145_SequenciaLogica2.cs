using System;

namespace SequenciaLogica2
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha = Console.ReadLine();
            string[] valores = linha.Split(' ');

            int x = Convert.ToInt32(valores[0]);
            int y = Convert.ToInt32(valores[1]);

            for (int i = 1; i <= y; i++)
            {
                Console.Write(i);

                if (i % x == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(' ');
                }
            }
        }
    }
}