using System;

namespace FusoHorario
{
    class Program
    {
        static void Main(string[] args)
        {
            int saida, tempo, fuso, destino;
            string[] linha = Console.ReadLine().Split(' ');

            saida = Convert.ToInt32(linha[0]);
            tempo = Convert.ToInt32(linha[1]);
            fuso = Convert.ToInt32(linha[2]);

            destino = saida + tempo + fuso;

            if (destino > 23)
            {
                destino = destino - 24;
            }

            if (destino < 0)
            {
                destino = destino + 24;
            }

            Console.WriteLine(destino);

        }
    }
}
