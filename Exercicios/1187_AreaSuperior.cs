using System;

namespace AreaSuperior
{
    class Program
    {
        static void Main(string[] args){

            double[,] matriz;
            matriz = new double[12, 12];

            char operacao = Convert.ToChar(Console.ReadLine());
            double soma = 0, media;
            int quant = 0, limite = 11;

            for (int i = 0; i < 12; i++){
                for (int j = 0; j < 12; j++){
                    matriz[i, j] = Convert.ToDouble(Console.ReadLine());

                    if (j > i && j > limite){
                        soma += matriz[i, j];
                        quant++;
                    }
                }
                limite--;
            }

            if (operacao == 'S'){
                Console.WriteLine("{0}", soma.ToString("0.0"));
            }else{
                media = soma / quant;
                Console.WriteLine("{0}", media.ToString("0.0"));
            }

        }
    }
}