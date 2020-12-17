using System;

namespace ColunaNaMatriz
{
    class Program
    {
        static void Main(string[] args){

            double[,] matriz;
            matriz = new double[12, 12];

            double soma = 0;
            double media;

            int coluna = Convert.ToInt32(Console.ReadLine());
            char operacao = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < 12; i++){
                for (int j = 0; j < 12; j++){
                    matriz[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            if (operacao == 'S'){
                for (int i = 0; i < 12; i++){
                    soma += matriz[i, coluna];
                }

                Console.WriteLine("{0}", soma.ToString("0.0"));

            }else{
                for (int i = 0; i < 12; i++){
                    soma += matriz[i, coluna];
                }
                
                media = soma / 12;
                Console.WriteLine("{0}", media.ToString("0.0"));
            }

        }
    }
}