using System;

namespace PreenchimentoDeVetor3
{
    class Program
    {
        static void Main(string[] args){

            double[] vetor;
            vetor = new double[100];

            double x = Convert.ToDouble(Console.ReadLine());
            vetor[0] = x;

            for (int i = 1; i < 100; i++){
                x /= 2;
                vetor[i] = x;
            }

            for (int i = 0; i < 100; i++){
                Console.WriteLine("N[{0}] = {1}", i.ToString("0"), vetor[i].ToString("0.0000"));
            }

        }
    }
}