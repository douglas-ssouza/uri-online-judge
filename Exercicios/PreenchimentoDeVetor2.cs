using System;

namespace PreenchimentoDeVetor2
{
    class Program
    {
        static void Main(string[] args){

            int[] vetor;
            vetor = new int[1000];

            int t = Convert.ToInt32(Console.ReadLine());
            int valor = 0;

            for (int i = 0; i < 1000; i++){
                vetor[i] = valor;
                valor++;
                if (valor == t){
                    valor = 0;
                }
            }

            for (int i = 0; i < 1000; i++){
                Console.WriteLine("N[" + i + "] = " + vetor[i]);
            }

        }
    }
}