using System;
using System.Globalization;

namespace MaiorEPosicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, maior = 0, pos = 0;

            for (int i = 0; i < 100; i++)
            {
                valor = Convert.ToInt32(Console.ReadLine());
                if (valor > maior)
                {
                    maior = valor;
                    pos = i + 1;
                }
            }

            Console.WriteLine(maior);
            Console.WriteLine(pos);
        }
    }
}
