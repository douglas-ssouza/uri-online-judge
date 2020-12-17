using System;

namespace MatrizQuadrada3
{
    class Program
    {
        static void Main(string[] args){

            int n, elemento;
            int[,] matriz;

            do{
                n = Convert.ToInt32(Console.ReadLine());

                if (n == 0){
                    break;
                }

                matriz = new int[n, n];
                elemento = 1;

                for (int linha = 0; linha < n; linha++){
                    for (int coluna = 0; coluna < n; coluna++){
                        matriz[linha, coluna] = elemento;
                        elemento *= 2;
                    }
                    elemento = matriz[linha, 0] * 2;
                }

                string ultimo = Convert.ToString(matriz[n-1, n-1]);
                int tamanho = ultimo.Length(); 

                for (int linha = 0; linha < n; linha++){
                    for (int coluna = 0; coluna < n; coluna++){
                        if (coluna == 0){
                            Console.Write("{0, tamanho}", matriz[linha, coluna]);
                        }else{
                            Console.Write(" {0, tamanho}", matriz[linha, coluna]);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

            } while (n != 0);

        }
    }
}