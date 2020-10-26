using System;

namespace TempoDeJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha = Console.ReadLine();
            string[] horas = linha.Split(' ');
            int inicio = Convert.ToInt32(horas[0]);
            int fim = Convert.ToInt32(horas[1]);
            int tempo;

            if (inicio == fim)
            {
                tempo = 24;
            }
            else if (inicio < fim)
            {
                tempo = fim - inicio;
            }
            else
            {
                tempo = (24 - inicio) + fim;
            }

            Console.WriteLine("O JOGO DUROU " + tempo + " HORA(S)");

        }
    }
}