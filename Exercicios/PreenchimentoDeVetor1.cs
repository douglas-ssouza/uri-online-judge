using System;

namespace PreenchimentoDeVetor1
{
    class Program
    {
        static void Main(string[] args){

            int[] vetor;
            vetor = new int[10];

            vetor[0] = Convert.ToInt32(Console.ReadLine());
            int valor = vetor[0];

            for (int i = 1; i < 10; i++){
                valor *= 2;
                vetor[i] = valor;
            }

            for (int i = 0; i < 10; i++){
                Console.WriteLine("N[" + i + "] = " + vetor[i]);
            }

        }
    }
}