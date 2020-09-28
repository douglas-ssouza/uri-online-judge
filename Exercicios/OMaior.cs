using System;

namespace OMaior
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, maior;
            string linha;

            linha = Console.ReadLine();
            string[] vetor = linha.Split(' ');
            a = Convert.ToInt32(vetor[0]);
            b = Convert.ToInt32(vetor[1]);
            c = Convert.ToInt32(vetor[2]);

            maior = (a + b + Math.Abs(a - b)) / 2;
            maior = (maior + c + Math.Abs(maior - c)) / 2;

            Console.WriteLine(maior + " eh o maior");
        }
    }
}
