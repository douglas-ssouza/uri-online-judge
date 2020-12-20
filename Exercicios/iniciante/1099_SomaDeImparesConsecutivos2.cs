using System;

namespace SomaDeImparesConsecutivos2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string linha;
            string[] valores;
            int inicio, fim, soma;

            for (int i = 0; i < n; i++)
            {
                soma = 0;

                linha = Console.ReadLine();
                valores = linha.Split(' ');
                inicio = Convert.ToInt32(valores[0]);
                fim = Convert.ToInt32(valores[1]);
                
                if (inicio < fim)
                {
                    for (int j = (inicio + 1); j < fim; j++)
                    {
                        if (j % 2 != 0)
                        {
                            soma += j;
                        }
                    }
                }

                if (inicio > fim)
                {
                    for (int j = (inicio - 1); j > fim; j--)
                    {
                        if (j % 2 != 0)
                        {
                            soma += j;
                        }
                    }
                }

                Console.WriteLine(soma);
            }
        }
    }
}
