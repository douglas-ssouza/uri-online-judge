using System;

namespace SequenciaLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int quadrado, cubo;

            for (int i = 1; i <= n; i++)
            {
                quadrado = i * i;
                cubo = i * i * i;

                Console.WriteLine(i + " " + quadrado + " " + cubo);
                quadrado++;
                cubo++;
                Console.WriteLine(i + " " + quadrado + " " + cubo);
            }
        }
    }
}