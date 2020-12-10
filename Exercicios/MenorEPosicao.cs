using System;

namespace MenorEPosicao
{
    class Program
    {
        static void Main(string[] args){

            int n = Convert.ToInt32(Console.ReadLine());

            int[] x;
            x = new int[n];

            string linha = Console.ReadLine();
            string[] valores = linha.Split(' ');

            int menor = Convert.ToInt32(valores[0]);
            int pos = 0;

            for (int i = 0; i < n; i++){
                x[i] = Convert.ToInt32(valores[i]);
                
                if (x[i] < menor){
                    menor = x[i];
                    pos = i;
                }
            }

            Console.WriteLine("Menor valor: " + menor);
            Console.WriteLine("Posicao: " + pos);

        }
    }
}