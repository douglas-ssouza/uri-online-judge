using System;

namespace Matriz123
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanho, linha, coluna;

            while (true)
            {

                string valor = Console.ReadLine();
                if (string.IsNullOrEmpty(valor))
                {
                    break;
                }

                tamanho = Convert.ToInt32(valor);
                int[,] matriz = new int[tamanho, tamanho];

                for (linha = 0; linha < tamanho; linha++)
                {
                    for (coluna = 0; coluna < tamanho; coluna++)
                    {
                        if (linha == coluna)
                        {
                            matriz[linha, coluna] = 1;
                        }
                        if (linha == tamanho - coluna - 1)
                        {
                            matriz[linha, coluna] = 2;
                        }
                        if (linha != coluna && linha != tamanho - coluna - 1)
                        {
                            matriz[linha, coluna] = 3;
                        }
                    }
                }

                for (linha = 0; linha < tamanho; linha++)
                {
                    for (coluna = 0; coluna < tamanho; coluna++)
                    {
                        Console.Write(matriz[linha, coluna]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
