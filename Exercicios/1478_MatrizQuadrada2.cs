using System;

namespace MatrizQuadrada2
{
    class Program
    {
        static void Main(string[] args){

            int n, elemento = 1;
            int[,] matriz;

            do{
                n = Convert.ToInt32(Console.ReadLine());
                if (n == 0){
                    break;
                }

                matriz = new int[n, n];

                for (int linha = 0; linha < n; linha++)
                {
                    for ( int coluna = 0; coluna < n; coluna++)
                    {
                        if (coluna == 0){
                            matriz[linha, coluna] = linha + 1;
                        }else if (linha > coluna){
                            matriz[linha, coluna] = linha - coluna + 1;
                        }else if (linha < coluna){
                            matriz[linha, coluna] = coluna - linha + 1;
                        }else{
                            matriz[linha, coluna] = 1;
                        }

                    }
                }

                for (int linha = 0; linha < n; linha++){
                    for (int coluna = 0; coluna < n; coluna++){
                        if(coluna == 0){
                            Console.Write("{0, 3}", matriz[linha, coluna]);
                        }else{
                            Console.Write(" {0, 3}", matriz[linha, colina]);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

            } while (n != 0);

        }
    }
}