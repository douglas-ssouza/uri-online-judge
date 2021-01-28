using System;

namespace MatrizQuadrada3
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanho;
            int valor;

            while (true)
            {

                tamanho = Convert.ToInt32(Console.ReadLine());
                if (tamanho == 0)
                {
                    break;
                }

                valor = 1;

                int[,] matriz = new int[tamanho, tamanho];

                for (int linha = 0; linha < tamanho; linha++)
                {
                    for (int coluna = 0; coluna < tamanho; coluna++)
                    {
                        matriz[linha, coluna] = valor;
                        valor = valor * 2;
                    }
                    valor = matriz[linha, 0] * 2;
                }

                string ultimo = Convert.ToString(matriz[tamanho - 1, tamanho - 1]);
                int espaco = ultimo.Length;

                for (int linha = 0; linha < tamanho; linha++)
                {
                    for (int coluna = 0; coluna < tamanho; coluna++)
                    {
                        switch (tamanho)
                        {
                            case 1:
                            case 2:
                                if (coluna == 0)
                                {
                                    Console.Write("{0, 1}", matriz[linha, coluna].ToString("0"));
                                }
                                else
                                {
                                    Console.Write(" {0, 1}", matriz[linha, coluna].ToString("0"));
                                }
                                break;
                            case 3:
                            case 4:
                                if (coluna == 0)
                                {
                                    Console.Write("{0, 2}", matriz[linha, coluna].ToString("0"));
                                }
                                else
                                {
                                    Console.Write(" {0, 2}", matriz[linha, coluna].ToString("0"));
                                }
                                break;
                            case 5:
                                if (coluna == 0)
                                {
                                    Console.Write("{0, 3}", matriz[linha, coluna].ToString("0"));
                                }
                                else
                                {
                                    Console.Write(" {0, 3}", matriz[linha, coluna].ToString("0"));
                                }
                                break;
                            case 6:
                            case 7:
                                if (coluna == 0)
                                {
                                    Console.Write("{0, 4}", matriz[linha, coluna].ToString("0"));
                                }
                                else
                                {
                                    Console.Write(" {0, 4}", matriz[linha, coluna].ToString("0"));
                                }
                                break;
                            case 8:
                            case 9:
                                if (coluna == 0)
                                {
                                    Console.Write("{0, 5}", matriz[linha, coluna].ToString("0"));
                                }
                                else
                                {
                                    Console.Write(" {0, 5}", matriz[linha, coluna].ToString("0"));
                                }
                                break;
                            case 10:
                                if (coluna == 0)
                                {
                                    Console.Write("{0, 6}", matriz[linha, coluna].ToString("0"));
                                }
                                else
                                {
                                    Console.Write(" {0, 6}", matriz[linha, coluna].ToString("0"));
                                }
                                break;
                            case 11:
                            case 12:
                                if (coluna == 0)
                                {
                                    Console.Write("{0, 7}", matriz[linha, coluna].ToString("0"));
                                }
                                else
                                {
                                    Console.Write(" {0, 7}", matriz[linha, coluna].ToString("0"));
                                }
                                break;
                            case 13:
                            case 14:
                                if (coluna == 0)
                                {
                                    Console.Write("{0, 8}", matriz[linha, coluna].ToString("0"));
                                }
                                else
                                {
                                    Console.Write(" {0, 8}", matriz[linha, coluna].ToString("0"));
                                }
                                break;
                            case 15:
                                if (coluna == 0)
                                {
                                    Console.Write("{0, 9}", matriz[linha, coluna].ToString("0"));
                                }
                                else
                                {
                                    Console.Write(" {0, 9}", matriz[linha, coluna].ToString("0"));
                                }
                                break;
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }
    }
}
