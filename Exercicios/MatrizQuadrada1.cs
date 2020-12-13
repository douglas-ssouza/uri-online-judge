using System;

namespace MatrizQuadrada1
{
    class Program
    {
        static void Main(string[] args){

            int n, iniMatriz, fimMatriz, valor;
            int[,] matriz;

            do{
                n = Convert.ToInt32(Console.ReadLine());
                
                if (n == 0){
                    break;
                }
                
                matriz = new int[n, n];

                iniMatriz = 0;
                fimMatriz = n;
                elemento = 1;

                do{
                    for (int linha = iniMatriz; linha < fimMatriz; linha++){
                        for (int coluna = iniMatriz; coluna < fimMatriz; coluna++){
                            matriz[linha, coluna] = elemento;
                        }
                    }
                    iniMatriz++;
                    elemento++;
                    fimMatriz--;
                } while (fimMatriz != 0);

                for (int linha = 0; linha < n; linha++){
                    for (int coluna = 0; coluna < n; coluna++){
                        if (coluna == 0){
                            Console.Write("{0, 3}", matriz[linha, coluna]);
                        }else{
                            Console.Write(" {0, 3}", matriz[linha, coluna]);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

            }while (n != 0);

        }
    }
}