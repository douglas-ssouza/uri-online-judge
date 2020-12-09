using System;

namespace TrocaEmVetor1
{
    class Program
    {
        static void Main(string[] args){

            int[] vetor;
            vetor = new int[20];

            for (int i = 0; i < 20; i++){
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            int aux, j = 19;

            for (int i = 0; i < 10; i++){
                aux = vetor[i];
                vetor[i] = vetor[j];
                vetor[j] = aux;
                j--;
            }

            for (int i = 0; i < 20; i++){
                Console.WriteLine("N[" + i + "] = " + vetor[i]);
            }

        }
    }
}