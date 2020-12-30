using System;

namespace ARespostaDeTheon
{
    class Program
    {
        static void Main(string[] args){

            int n = Convert.ToInt32(Console.ReadLine());
            int[] opcoes;
            opcoes = new int[n];

            string[] linha = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++){
                opcoes[i] = Convert.ToInt32(linha[i]);
            }

            int menor = opcoes[0];
            int resposta = 1;

            for (int i = 0; i < n; i++){
                if (opcoes[i] < menor){
                    menor = opcoes[i];
                    resposta = i + 1;
                }
            }

            Console.WriteLine(resposta);

        }
    }
}