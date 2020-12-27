using System;

namespace MatrizQuadrada4
{
    class Program
    {
        static void Main(string[] args){

            while (true){
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)){
                    break;
                }

                int n = Convert.ToInt32(input);
                int[,] matriz;
                matriz = new int[n, n];

                for (int linha = 0; linha < n; linha++){
                    for (int coluna = 0; coluna < n; coluna++){
                        if (linha == coluna){
                            matriz[linha, coluna] = 2;
                        }else if (linha == n - coluna - 1){
                            matriz[linha, coluna] = 3;
                        }else{
                            matriz[linha, coluna] = 0;
                        }
                    }
                }

                int inicio = n / 3;
                int fim = n - inicio;

                for (int linha = inicio; linha < fim; linha++){
                    for (int coluna = inicio; coluna < fim; coluna++){
                        matriz[i, j] = 1;
                    }
                }

                matriz[n/2, n/2] = 4;

                for (int i = 0; i < n; i++){
                    for (int j = 0; j < n; j++){
                        Console.Write(matriz[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}