using System;

namespace ODespertarDaForca
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tamanho = Console.ReadLine().Split(' ');
            
            int linhas, colunas;
            linhas = Convert.ToInt32(tamanho[0]);
            colunas = Convert.ToInt32(tamanho[1]);
            int[,] matriz = new int[linhas, colunas];

            string pos = "0 0";

            for (int linha = 0; linha < linhas; linha++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int coluna = 0; coluna < valores.Length; coluna++)
                {
                    matriz[linha, coluna] = Convert.ToInt32(valores[coluna]);
                }
            }

            for (int linha = 0; linha < linhas; linha++)
            {
                for (int coluna = 0; coluna < colunas; coluna++)
                {
                    if (matriz[linha, coluna] == 42 && coluna != colunas-1 && coluna != 0 && linha != linhas-1 && linha != 0)
                    {
                            if (matriz[linha, coluna - 1] == 7 && matriz[linha, coluna + 1] == 7
                            && matriz[linha - 1, coluna - 1] == 7 && matriz[linha - 1, coluna] == 7 && matriz[linha - 1, coluna + 1] == 7
                            && matriz[linha + 1, coluna - 1] == 7 && matriz[linha + 1, coluna] == 7 && matriz[linha + 1, coluna + 1] == 7)
                            {
                                pos = Convert.ToString(linha + 1) + " " + Convert.ToString(coluna + 1);
                            }
                    }
                }
            }

            Console.WriteLine(pos);
        }
    }
}
